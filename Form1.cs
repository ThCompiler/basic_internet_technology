using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace IT4 {
    public partial class Form1 : Form {
        private List<string> _gotText = new List<string>();

        private Stopwatch _watch = new Stopwatch();

        public Form1() {
            InitializeComponent();

            ButtonSearch.Visible = false;
            LabelTimeSearch.Visible = false;
            ListBoxResultSearch.Visible = false;
            LabelTimeLoad.Visible = false;
            InputWord.Visible = false;

            Height = 120;
        }

        private bool TryGetFile(string filter) {
            var filePath = string.Empty;

            OpenFileDialog.InitialDirectory = "c:\\";
            OpenFileDialog.Filter = filter;
            OpenFileDialog.FilterIndex = 2;
            OpenFileDialog.RestoreDirectory = true;

            return OpenFileDialog.ShowDialog() == DialogResult.OK;
        }

        private List<string> GetFileText() {
            if(!TryGetFile("txt files (*.txt)|*.txt")) {
                return null;
            }

            _watch.Start();
            var fileStream = OpenFileDialog.OpenFile();
            var fileContent = string.Empty;

            using (StreamReader reader = new StreamReader(fileStream)) {
                fileContent = reader.ReadToEnd();
            }

            var got_list = fileContent.Split(" ,.;?!\"\'\n\t«»)(".ToCharArray());

            List<string> list = new List<string>();
            foreach(string word in got_list) {
                if(!list.Contains(word)) {
                    list.Add(word);
                }
            }

            return list;
        }

        private void ButtonLoad_Click(object sender, EventArgs e) {
            _gotText = GetFileText();
            
            if(_gotText is null) { 
                _watch.Stop();
                return;
            }
            _watch.Stop();

            LabelTimeLoad.Text = "Затраченое время: " 
                            + _watch.ElapsedTicks.ToString() + " ticks";

            if (Height > 170) return;
            ButtonSearch.Visible = true;
            LabelTimeLoad.Visible = true;
            InputWord.Visible = true;

            Height = 170;
        }

        private void ButtonSearch_Click(object sender, EventArgs e) {
            string word = InputWord.Text;

            _watch.Start();
            ListBoxResultSearch.BeginUpdate();
            ListBoxResultSearch.Items.Clear();

            foreach (var check_word in _gotText) {
                if (check_word.Contains(word)) {
                    ListBoxResultSearch.Items.Add(check_word);
                }
            }

            ListBoxResultSearch.EndUpdate();
            _watch.Stop();

            LabelTimeSearch.Text = "Затраченое время: " 
                            + _watch.ElapsedTicks.ToString() + " ticks";
            LabelTimeSearch.Visible = true;
            ListBoxResultSearch.Visible = true;

            Height = 264;
        }

//-----------------------------------------------------------------------------------

        private void ListBoxResultSearch_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void LabelTimeLoad_Click(object sender, EventArgs e) {

        }

        private void LabelTimeSearch_Click(object sender, EventArgs e) {

        }

    }
}
