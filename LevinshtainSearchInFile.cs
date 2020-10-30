using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using CompareString;

namespace DZ {
    public partial class LevinshtainSearchFile : Form {
        private List<string> _GotText = new List<string>();

        private long _k = 0;
        private Stopwatch _watch = new Stopwatch();

        public LevinshtainSearchFile() {
            InitializeComponent();

            TextSetK.Visible = false;
            ButtonSetK.Visible = false;
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
            _GotText = GetFileText();

            _watch.Stop();
            if(_GotText is null) { 
                return;
            }

            LabelTimeLoad.Text = "Затраченое время: " 
                            + _watch.ElapsedTicks.ToString() + "ticks";

            if (Height > 170) return;
            ButtonSetK.Visible = true;
            LabelTimeLoad.Visible = true;
            TextSetK.Visible = true;

            Height = 170;
        }

        private void ButtonSetK_Click(object sender, EventArgs e) {
            if(TextSetK.Text.Length is 0) {
                return;
            }
            if (!long.TryParse(TextSetK.Text, out _k)) {
                _k = 0;
            }

            if (Height > 200) return;
            ButtonSearch.Visible = true;
            InputWord.Visible = true;
            Height = 200;
        }


        private void ButtonSearch_Click(object sender, EventArgs e) {
            string word = InputWord.Text;

            _watch.Start();
            ListBoxResultSearch.BeginUpdate();
            ListBoxResultSearch.Items.Clear();

            foreach (var check_word in _GotText) {
                if (MyEqualerString.Equal(check_word, word, MyEqualerString.Damerau_LevenshteinDistance, _k)) {
                    ListBoxResultSearch.Items.Add(check_word);
                }
            }

            ListBoxResultSearch.EndUpdate();
            _watch.Stop();

            LabelTimeSearch.Text = "Затраченое время: " 
                            + _watch.ElapsedTicks.ToString() + "ticks";
            LabelTimeSearch.Visible = true;
            ListBoxResultSearch.Visible = true;

            Height = 294;
        }

//-----------------------------------------------------------------------------------

        private void ListBoxResultSearch_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void LabelTimeLoad_Click(object sender, EventArgs e) {

        }

        private void LabelTimeSearch_Click(object sender, EventArgs e) {

        }

        private void TextSetK_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void LevinshtainSearchFile_Load(object sender, EventArgs e) {
            Owner.Visible = false;
        }

        private void LevinshtainSearchFile_FormClosed(object sender, FormClosedEventArgs e) {
            Owner.Visible = true;
        }
    }
}
