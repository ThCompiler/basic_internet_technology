namespace IT4 {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.LabelTimeLoad = new System.Windows.Forms.Label();
            this.InputWord = new System.Windows.Forms.TextBox();
            this.LabelTimeSearch = new System.Windows.Forms.Label();
            this.ListBoxResultSearch = new System.Windows.Forms.ListBox();
            this.TextSetK = new System.Windows.Forms.TextBox();
            this.ButtonSetK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(28, 33);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(395, 32);
            this.ButtonLoad.TabIndex = 0;
            this.ButtonLoad.Text = "Загрузить";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(306, 129);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSearch.Size = new System.Drawing.Size(117, 30);
            this.ButtonSearch.TabIndex = 1;
            this.ButtonSearch.Text = "Найти";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // LabelTimeLoad
            // 
            this.LabelTimeLoad.AutoSize = true;
            this.LabelTimeLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTimeLoad.ForeColor = System.Drawing.Color.LimeGreen;
            this.LabelTimeLoad.Location = new System.Drawing.Point(24, 68);
            this.LabelTimeLoad.Name = "LabelTimeLoad";
            this.LabelTimeLoad.Size = new System.Drawing.Size(135, 22);
            this.LabelTimeLoad.TabIndex = 2;
            this.LabelTimeLoad.Text = "LabelTimeLoad";
            this.LabelTimeLoad.Click += new System.EventHandler(this.LabelTimeLoad_Click);
            // 
            // InputWord
            // 
            this.InputWord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputWord.Location = new System.Drawing.Point(28, 128);
            this.InputWord.Name = "InputWord";
            this.InputWord.Size = new System.Drawing.Size(253, 30);
            this.InputWord.TabIndex = 3;
            // 
            // LabelTimeSearch
            // 
            this.LabelTimeSearch.AutoSize = true;
            this.LabelTimeSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTimeSearch.ForeColor = System.Drawing.Color.LimeGreen;
            this.LabelTimeSearch.Location = new System.Drawing.Point(24, 252);
            this.LabelTimeSearch.Name = "LabelTimeSearch";
            this.LabelTimeSearch.Size = new System.Drawing.Size(149, 22);
            this.LabelTimeSearch.TabIndex = 4;
            this.LabelTimeSearch.Text = "LabelTimeSearch";
            this.LabelTimeSearch.Click += new System.EventHandler(this.LabelTimeSearch_Click);
            // 
            // ListBoxResultSearch
            // 
            this.ListBoxResultSearch.FormattingEnabled = true;
            this.ListBoxResultSearch.ItemHeight = 16;
            this.ListBoxResultSearch.Location = new System.Drawing.Point(28, 164);
            this.ListBoxResultSearch.Name = "ListBoxResultSearch";
            this.ListBoxResultSearch.Size = new System.Drawing.Size(395, 84);
            this.ListBoxResultSearch.TabIndex = 5;
            this.ListBoxResultSearch.SelectedIndexChanged += new System.EventHandler(this.ListBoxResultSearch_SelectedIndexChanged);
            // 
            // TextSetK
            // 
            this.TextSetK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextSetK.Location = new System.Drawing.Point(75, 93);
            this.TextSetK.Name = "TextSetK";
            this.TextSetK.Size = new System.Drawing.Size(206, 30);
            this.TextSetK.TabIndex = 6;
            this.TextSetK.Text = "0";
            this.TextSetK.TextChanged += new System.EventHandler(this.TextSetK_TextChanged);
            // 
            // ButtonSetK
            // 
            this.ButtonSetK.Location = new System.Drawing.Point(306, 93);
            this.ButtonSetK.Name = "ButtonSetK";
            this.ButtonSetK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSetK.Size = new System.Drawing.Size(117, 30);
            this.ButtonSetK.TabIndex = 7;
            this.ButtonSetK.Text = "Установить";
            this.ButtonSetK.UseVisualStyleBackColor = true;
            this.ButtonSetK.Click += new System.EventHandler(this.ButtonSetK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "K =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSetK);
            this.Controls.Add(this.TextSetK);
            this.Controls.Add(this.ListBoxResultSearch);
            this.Controls.Add(this.LabelTimeSearch);
            this.Controls.Add(this.InputWord);
            this.Controls.Add(this.LabelTimeLoad);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label LabelTimeLoad;
        private System.Windows.Forms.TextBox InputWord;
        private System.Windows.Forms.Label LabelTimeSearch;
        private System.Windows.Forms.ListBox ListBoxResultSearch;
        private System.Windows.Forms.TextBox TextSetK;
        private System.Windows.Forms.Button ButtonSetK;
        private System.Windows.Forms.Label label1;
    }
}

