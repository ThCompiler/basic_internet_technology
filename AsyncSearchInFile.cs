using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompareString;
using SearchString;

namespace DZ {
    public partial class AzyncSezrchInFile : Form {
        private Stopwatch _Watch = new Stopwatch();
        private SearchString.AzyncSearch _Searching = new SearchString.AzyncSearch();

        private (List<string> found_string, List<long> times) _LastResult;

        public AzyncSezrchInFile() {
            InitializeComponent();

            TextSetK.Visible = false;
            labelSetK.Visible = false;
            InputWord.Visible = false;
            ButtonSetK.Visible = false;
            SaveReport.Visible = false;
            LoadDiagram.Visible = false;
            ButtonSearch.Visible = false;
            LabelTimeLoad.Visible = false;
            NumberOfTheard.Visible = false;
            LabelTimeSearch.Visible = false;
            labelNumberThreads.Visible = false;
            ListBoxResultSearch.Visible = false;
            ButtonSetNuberThreads.Visible = false;

            SearchString.AzyncSearch.IsEquls = (string a, string b)
                                    => MyEqualerString.Equal(a, b, MyEqualerString.Damerau_LevenshteinDistance, 0);
            Height = 90;
        }

        private bool TryGetFile(string filter) {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = filter;
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            return openFileDialog.ShowDialog() == DialogResult.OK;
        }

        private List<string> GetFileText() {
            if (!TryGetFile("txt files (*.txt)|*.txt")) {
                return null;
            }

            _Watch.Start();
            var fileStream = openFileDialog.OpenFile();
            var fileContent = string.Empty;

            using (StreamReader reader = new StreamReader(fileStream)) {
                fileContent = reader.ReadToEnd();
            }

            var got_list = fileContent.Split(" ,.;?!\"\'\n\t«»)(".ToCharArray());

            List<string> list = new List<string>();
            foreach (string word in got_list) {
                if (!list.Contains(word)) {
                    list.Add(word);
                }
            }

            return list;
        }


        private void ButtonSearch_Click(object sender, EventArgs e) {
            string word = InputWord.Text;

            _LastResult = _Searching.Search(word, long.Parse(TextSetK.Text));

            ListBoxResultSearch.BeginUpdate();
            ListBoxResultSearch.Items.Clear();

            foreach (var s in _LastResult.found_string) {
                ListBoxResultSearch.Items.Add(s);
            }

            ListBoxResultSearch.EndUpdate();

            LabelTimeSearch.Text = _Searching.GetLastStatistic.time.ToString() + " ticks";
            LabelTimeSearch.Visible = true;
            ListBoxResultSearch.Visible = true;


            SaveReport.Visible = true;
            LoadDiagram.Visible = true;

            Height = 345;
        }

        private void ButtonLoad_Click(object sender, EventArgs e) {
            List<string> GotText = GetFileText();

            _Watch.Stop();
            if (GotText is null) {
                return;
            }

            LabelTimeLoad.Text = _Watch.ElapsedTicks.ToString() + " ticks";

            _Searching = new SearchString.AzyncSearch(GotText);

            if (Height > 150) return;

            ButtonSetK.Visible = true;
            LabelTimeLoad.Visible = true;
            TextSetK.Visible = true;
            labelSetK.Visible = true;

            Height = 150;
        }

        private void ButtonSetK_Click(object sender, EventArgs e) {
            if (TextSetK.Text.Length is 0) {
                MessageBox.Show("Поле ввода пусто!");
                return;
            }


            long k = 0;
            if (!long.TryParse(TextSetK.Text, out k)) {
                MessageBox.Show("Вы ввели вместо пороговой длины неизвестный символ!");
                return;
            }

            SearchString.AzyncSearch.IsEquls = (string a, string b)
                                    => MyEqualerString.Equal(a, b, MyEqualerString.Damerau_LevenshteinDistance, k);

            if (Height > 180) return;

            ButtonSetNuberThreads.Visible = true;
            NumberOfTheard.Visible = true;
            labelNumberThreads.Visible = true;
            Height = 180;
        }

        private void AzyncSezrchInFile_Load(object sender, EventArgs e) {
            Owner.Visible = false;
        }

        private void AzyncSezrchInFile_FormClosed(object sender, FormClosedEventArgs e) {
            Owner.Visible = true;
        }

        private void labelSetK_Click(object sender, EventArgs e) {

        }

        private void SetNuberThreads_Click(object sender, EventArgs e) {
            if (NumberOfTheard.Text.Length is 0) {
                MessageBox.Show("Поле ввода пусто!");
                return;
            }

            if (!long.TryParse(NumberOfTheard.Text, out AzyncSearch.NumberThread)) {
                MessageBox.Show("Вы ввели вместо числа потоков неизвестный символ!");
            }

            if (Height > 210) return;

            ButtonSearch.Visible = true;
            InputWord.Visible = true;
            Height = 210;
        }

        private void LoadDiagram_Click(object sender, EventArgs e) {
            var Diagram = new ResultDiagram(_LastResult.times, "Ticks");

            Diagram.ShowDialog();
        }

        private string _PrepairReport(string ReportFileName) {
            string stringReport = "";

            stringReport += "<html>";

            stringReport += "<head>";
            stringReport += "<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'/>";
            stringReport += "<title>" + "Отчет: " + ReportFileName + "</title>";
            stringReport += "</head>";

            stringReport += "<body>";

            stringReport += "<h1>" + "Отчет: " + ReportFileName + "</h1>";
            stringReport += "<table border='1'>";

            stringReport += "<tr>";
            stringReport += "<td>Время чтения из файла</td>";
            stringReport += "<td>" + LabelTimeLoad.Text + "</td>";
            stringReport += "</tr>";

            stringReport += "<tr>";
            stringReport += "<td>Количество уникальных слов в файле</td>";
            stringReport += "<td>" + _Searching.Text.Count + "</td>";
            stringReport += "</tr>";

            stringReport += "<tr>";
            stringReport += "<td>Слово для поиска</td>";
            stringReport += "<td>" + InputWord.Text + "</td>";
            stringReport += "</tr>";

            stringReport += "<tr>";
            stringReport += "<td>Пороговая длина поиска</td>";
            stringReport += "<td>" + TextSetK.Text + "</td>";
            stringReport += "</tr>";

            stringReport += "<tr>";
            stringReport += "<td>Время общего поиска</td>";
            stringReport += "<td>" + LabelTimeSearch.Text + "</td>";
            stringReport += "</tr>";

            stringReport += "<tr>";
            stringReport += "<td>Максимальнео время работы потока</td>";
            stringReport += "<td>" + _LastResult.times.Max().ToString() + " ticks</td>";
            stringReport += "</tr>";

            stringReport += "<tr valign='top'>";
            stringReport += "<td>Результаты поиска</td>";
            stringReport += "<td>";
            stringReport += "<ul>";

            foreach (var word in this._LastResult.found_string) {
                stringReport += "<li>" + word.ToString() + "</li>";
            }

            stringReport += "</ul>";
            stringReport += "</td>";
            stringReport += "</tr>";

            stringReport += "<tr valign='top'>";
            stringReport += "<td>Время по потокам в тиках</td>";
            stringReport += "<td>";
            stringReport += "<ul>";

            long i = 1;
            foreach (var word in this._LastResult.times) {
                stringReport += "<li> " + i++.ToString() + " : "  + word.ToString() + "</li>";
            }

            stringReport += "</ul>";
            stringReport += "</td>";
            stringReport += "</tr>";

            stringReport += "</table>";

            stringReport += "</body>";
            stringReport += "</html>";

            return stringReport;
        }

        private void SaveReport_Click(object sender, EventArgs e) {
            SaveFileDialog ReportFile = new SaveFileDialog();
            ReportFile.FileName = "report_" + DateTime.Now.ToString("hh;mm;ss_dd_MM_yy"); ;
            ReportFile.DefaultExt = ".html";
            ReportFile.Filter = "HTML Reports|*.html";

            if (ReportFile.ShowDialog() == DialogResult.OK) {
                File.AppendAllText(ReportFile.FileName, _PrepairReport(ReportFile.FileName));

                MessageBox.Show("Отчет готов. Сохранён в файле: " + ReportFile.FileName);
            }
        }
    }
}
