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
    public partial class Formcarta : Form
    {
        public Formcarta()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#f9b3b5");
            textocarta.BackColor = System.Drawing.ColorTranslator.FromHtml("#f9b3b5");
            textocarta.Text = "";
            textocarta.ReadOnly = true;
        }

        private void textocarta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
