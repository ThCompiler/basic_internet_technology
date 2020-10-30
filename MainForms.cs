using IT4;
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
    public partial class MainForms : Form {
        public MainForms() {
            InitializeComponent();
        }

        private void MainForms_Load(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            AzyncSezrchInFile taskWindow = new AzyncSezrchInFile();

            //Теперь MainWindow главное окно для taskWindow
            taskWindow.Owner = this;

            taskWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            StandartSearchInFile taskWindow = new StandartSearchInFile();

            //Теперь MainWindow главное окно для taskWindow
            taskWindow.Owner = this;

            taskWindow.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            LevinshtainSearchFile taskWindow = new LevinshtainSearchFile();

            //Теперь MainWindow главное окно для taskWindow
            taskWindow.Owner = this;

            taskWindow.Show();
        }
    }
}
