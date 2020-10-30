namespace DZ {
    partial class ResultDiagram {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Diagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MaxElement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Diagram)).BeginInit();
            this.SuspendLayout();
            // 
            // Diagram
            // 
            chartArea1.Name = "ChartArea1";
            this.Diagram.ChartAreas.Add(chartArea1);
            legend1.Name = "legend1";
            this.Diagram.Legends.Add(legend1);
            this.Diagram.Location = new System.Drawing.Point(12, 12);
            this.Diagram.Name = "Diagram";
            this.Diagram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.Diagram.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Magenta};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "legend1";
            series1.Name = "Tiks";
            this.Diagram.Series.Add(series1);
            this.Diagram.Size = new System.Drawing.Size(651, 426);
            this.Diagram.TabIndex = 1;
            this.Diagram.Text = "Diagram";
            // 
            // MaxElement
            // 
            this.MaxElement.AutoSize = true;
            this.MaxElement.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxElement.Location = new System.Drawing.Point(212, 444);
            this.MaxElement.Name = "MaxElement";
            this.MaxElement.Size = new System.Drawing.Size(136, 27);
            this.MaxElement.TabIndex = 2;
            this.MaxElement.Text = "MaxElement";
            // 
            // ResultDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 480);
            this.Controls.Add(this.MaxElement);
            this.Controls.Add(this.Diagram);
            this.Name = "ResultDiagram";
            this.Text = "ResultDiagram";
            ((System.ComponentModel.ISupportInitialize)(this.Diagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Diagram;
        private System.Windows.Forms.Label MaxElement;
    }
}