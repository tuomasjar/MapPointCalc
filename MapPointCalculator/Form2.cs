using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapPointCalculator {
    public partial class Form2 : Form {
        public String returnValue;
        public Form2() {
            InitializeComponent();
        }

        private void btnAmerica_Click(object sender, EventArgs e) {
            this.returnValue = "America";
            this.DialogResult= DialogResult.OK;
            this.Close();
        }

        private void btnEurope_Click(object sender, EventArgs e) {
            this.returnValue = "Europe";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
