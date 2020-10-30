namespace DZ {
    partial class AzyncSezrchInFile {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.LabelTimeSearch = new System.Windows.Forms.Label();
            this.InputWord = new System.Windows.Forms.TextBox();
            this.LabelTimeLoad = new System.Windows.Forms.Label();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ListBoxResultSearch = new System.Windows.Forms.ListBox();
            this.TimeSearch = new System.Windows.Forms.Label();
            this.labelSetK = new System.Windows.Forms.Label();
            this.ButtonSetK = new System.Windows.Forms.Button();
            this.TextSetK = new System.Windows.Forms.TextBox();
            this.LoadDiagram = new System.Windows.Forms.Button();
            this.SaveReport = new System.Windows.Forms.Button();
            this.labelNumberThreads = new System.Windows.Forms.Label();
            this.ButtonSetNuberThreads = new System.Windows.Forms.Button();
            this.NumberOfTheard = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(12, 21);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(395, 32);
            this.ButtonLoad.TabIndex = 1;
            this.ButtonLoad.Text = "Загрузить";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // LabelTimeSearch
            // 
            this.LabelTimeSearch.AutoSize = true;
            this.LabelTimeSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTimeSearch.ForeColor = System.Drawing.Color.LimeGreen;
            this.LabelTimeSearch.Location = new System.Drawing.Point(166, 282);
            this.LabelTimeSearch.Name = "LabelTimeSearch";
            this.LabelTimeSearch.Size = new System.Drawing.Size(149, 22);
            this.LabelTimeSearch.TabIndex = 9;
            this.LabelTimeSearch.Text = "LabelTimeSearch";
            // 
            // InputWord
            // 
            this.InputWord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputWord.Location = new System.Drawing.Point(12, 158);
            this.InputWord.Name = "InputWord";
            this.InputWord.Size = new System.Drawing.Size(253, 30);
            this.InputWord.TabIndex = 8;
            // 
            // LabelTimeLoad
            // 
            this.LabelTimeLoad.AutoSize = true;
            this.LabelTimeLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTimeLoad.ForeColor = System.Drawing.Color.LimeGreen;
            this.LabelTimeLoad.Location = new System.Drawing.Point(8, 61);
            this.LabelTimeLoad.Name = "LabelTimeLoad";
            this.LabelTimeLoad.Size = new System.Drawing.Size(135, 22);
            this.LabelTimeLoad.TabIndex = 7;
            this.LabelTimeLoad.Text = "LabelTimeLoad";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(290, 158);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSearch.Size = new System.Drawing.Size(117, 30);
            this.ButtonSearch.TabIndex = 6;
            this.ButtonSearch.Text = "Найти";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ListBoxResultSearch
            // 
            this.ListBoxResultSearch.FormattingEnabled = true;
            this.ListBoxResultSearch.ItemHeight = 16;
            this.ListBoxResultSearch.Location = new System.Drawing.Point(12, 195);
            this.ListBoxResultSearch.Name = "ListBoxResultSearch";
            this.ListBoxResultSearch.Size = new System.Drawing.Size(253, 84);
            this.ListBoxResultSearch.TabIndex = 10;
            // 
            // TimeSearch
            // 
            this.TimeSearch.AutoSize = true;
            this.TimeSearch.Location = new System.Drawing.Point(12, 286);
            this.TimeSearch.Name = "TimeSearch";
            this.TimeSearch.Size = new System.Drawing.Size(148, 17);
            this.TimeSearch.TabIndex = 11;
            this.TimeSearch.Text = "Общее время поиска";
            // 
            // labelSetK
            // 
            this.labelSetK.AutoSize = true;
            this.labelSetK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSetK.ForeColor = System.Drawing.Color.Black;
            this.labelSetK.Location = new System.Drawing.Point(13, 89);
            this.labelSetK.Name = "labelSetK";
            this.labelSetK.Size = new System.Drawing.Size(40, 22);
            this.labelSetK.TabIndex = 14;
            this.labelSetK.Text = "K =";
            this.labelSetK.Click += new System.EventHandler(this.labelSetK_Click);
            // 
            // ButtonSetK
            // 
            this.ButtonSetK.Location = new System.Drawing.Point(290, 86);
            this.ButtonSetK.Name = "ButtonSetK";
            this.ButtonSetK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSetK.Size = new System.Drawing.Size(117, 30);
            this.ButtonSetK.TabIndex = 13;
            this.ButtonSetK.Text = "Установить";
            this.ButtonSetK.UseVisualStyleBackColor = true;
            this.ButtonSetK.Click += new System.EventHandler(this.ButtonSetK_Click);
            // 
            // TextSetK
            // 
            this.TextSetK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextSetK.Location = new System.Drawing.Point(59, 86);
            this.TextSetK.Name = "TextSetK";
            this.TextSetK.Size = new System.Drawing.Size(206, 30);
            this.TextSetK.TabIndex = 12;
            this.TextSetK.Text = "0";
            // 
            // LoadDiagram
            // 
            this.LoadDiagram.Location = new System.Drawing.Point(15, 307);
            this.LoadDiagram.Name = "LoadDiagram";
            this.LoadDiagram.Size = new System.Drawing.Size(145, 50);
            this.LoadDiagram.TabIndex = 15;
            this.LoadDiagram.Text = "Времена по потокам";
            this.LoadDiagram.UseVisualStyleBackColor = true;
            this.LoadDiagram.Click += new System.EventHandler(this.LoadDiagram_Click);
            // 
            // SaveReport
            // 
            this.SaveReport.Location = new System.Drawing.Point(166, 307);
            this.SaveReport.Name = "SaveReport";
            this.SaveReport.Size = new System.Drawing.Size(138, 29);
            this.SaveReport.TabIndex = 16;
            this.SaveReport.Text = "Сохранить отчёт";
            this.SaveReport.UseVisualStyleBackColor = true;
            this.SaveReport.Click += new System.EventHandler(this.SaveReport_Click);
            // 
            // labelNumberThreads
            // 
            this.labelNumberThreads.AutoSize = true;
            this.labelNumberThreads.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberThreads.ForeColor = System.Drawing.Color.Black;
            this.labelNumberThreads.Location = new System.Drawing.Point(13, 125);
            this.labelNumberThreads.Name = "labelNumberThreads";
            this.labelNumberThreads.Size = new System.Drawing.Size(152, 22);
            this.labelNumberThreads.TabIndex = 19;
            this.labelNumberThreads.Text = "Число потоков =";
            // 
            // ButtonSetNuberThreads
            // 
            this.ButtonSetNuberThreads.Location = new System.Drawing.Point(290, 122);
            this.ButtonSetNuberThreads.Name = "ButtonSetNuberThreads";
            this.ButtonSetNuberThreads.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSetNuberThreads.Size = new System.Drawing.Size(117, 30);
            this.ButtonSetNuberThreads.TabIndex = 18;
            this.ButtonSetNuberThreads.Text = "Установить";
            this.ButtonSetNuberThreads.UseVisualStyleBackColor = true;
            this.ButtonSetNuberThreads.Click += new System.EventHandler(this.SetNuberThreads_Click);
            // 
            // NumberOfTheard
            // 
            this.NumberOfTheard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfTheard.Location = new System.Drawing.Point(171, 122);
            this.NumberOfTheard.Name = "NumberOfTheard";
            this.NumberOfTheard.Size = new System.Drawing.Size(94, 30);
            this.NumberOfTheard.TabIndex = 17;
            this.NumberOfTheard.Text = "10";
            // 
            // AzyncSezrchInFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 369);
            this.Controls.Add(this.labelNumberThreads);
            this.Controls.Add(this.ButtonSetNuberThreads);
            this.Controls.Add(this.NumberOfTheard);
            this.Controls.Add(this.SaveReport);
            this.Controls.Add(this.LoadDiagram);
            this.Controls.Add(this.labelSetK);
            this.Controls.Add(this.ButtonSetK);
            this.Controls.Add(this.TextSetK);
            this.Controls.Add(this.TimeSearch);
            this.Controls.Add(this.ListBoxResultSearch);
            this.Controls.Add(this.LabelTimeSearch);
            this.Controls.Add(this.InputWord);
            this.Controls.Add(this.LabelTimeLoad);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonLoad);
            this.Name = "AzyncSezrchInFile";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AzyncSezrchInFile_FormClosed);
            this.Load += new System.EventHandler(this.AzyncSezrchInFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Label LabelTimeSearch;
        private System.Windows.Forms.TextBox InputWord;
        private System.Windows.Forms.Label LabelTimeLoad;
        private System.Windows.Forms.Label labelSetK;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox ListBoxResultSearch;
        private System.Windows.Forms.Label TimeSearch;
        private System.Windows.Forms.Button ButtonSetK;
        private System.Windows.Forms.TextBox TextSetK;
        private System.Windows.Forms.Button LoadDiagram;
        private System.Windows.Forms.Button SaveReport;
        private System.Windows.Forms.Label labelNumberThreads;
        private System.Windows.Forms.Button ButtonSetNuberThreads;
        private System.Windows.Forms.TextBox NumberOfTheard;
    }
}