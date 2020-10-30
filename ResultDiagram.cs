using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ {
    public partial class ResultDiagram : Form {
        public ResultDiagram() {
            InitializeComponent();
        }

        public ResultDiagram(List<long> date, string seriesName) {
            InitializeComponent();

            foreach(var i in date) {
                Diagram.Series[0].Points.Add(i);
            }

            Diagram.Series[0].Name = seriesName;

            MaxElement.Text = "Максимальное значение: " + date.Max().ToString();
        }
    }
}
