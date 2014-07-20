using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaGithub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Carolina();
            Carlos CASM = new Carlos("SNSD", "Tiffany Hwang & Hayley Williams", "Calle 7", 7);
        }

        private void Carolina() {

            Label lbl = new Label();
            lbl.Text = "Hola Cejitas...";
        
        }
    }
}
