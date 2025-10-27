using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace johana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#f9b3b5");
            bncarta.BackColor = ColorTranslator.FromHtml("#f8bca3");
            bncarta.FlatStyle = FlatStyle.Flat;
            bncarta.FlatAppearance.BorderSize = 0;
            bnsalir.BackColor = ColorTranslator.FromHtml("#f8bca3");
            bnsalir.FlatStyle = FlatStyle.Flat;
            bnsalir.FlatAppearance.BorderSize = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bncarta_Click(object sender, EventArgs e)
        {
            Formcarta formcarta = new Formcarta();
            this.Hide();
            formcarta.Show();
        }

        private void bnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
