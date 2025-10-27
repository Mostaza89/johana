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
            bnsalir.BackColor = ColorTranslator.FromHtml("#f8bca3");
            bnsalir.FlatStyle = FlatStyle.Flat;
            bnsalir.UseVisualStyleBackColor = false;
            bnsalir.FlatAppearance.BorderSize = 2;
            bnsalir.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#701705");

            bnregresar.BackColor = ColorTranslator.FromHtml("#f8bca3");
            bnregresar.FlatStyle = FlatStyle.Flat;
            bnregresar.UseVisualStyleBackColor = false;
            bnregresar.FlatAppearance.BorderSize = 2;
            bnregresar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#701705");
            textocarta.BackColor = System.Drawing.ColorTranslator.FromHtml("#f9b3b5");
            textocarta.ReadOnly = true;
            textocarta.Text = "Hola Johana, no soy muy bueno escribiendo ni expresándome, pero me haces sentir muy feliz y quería hacer esto para ti. Ya hemos hablado de lo que sentimos el uno por él otro, pero me siento muy feliz al decirte lo mucho que te quiero y lo especial que eres para mí, también como te me haces una persona muy bonita. El tiempo que llevamos conociéndonos se me ha hecho tan mágico, el como eres tan encantadora, chistosa, espontanea y maravillosa me hace sentirme como si estuviera constantemente en la canción las linda que haya escuchado, me gustas mucho Johana, te quiero mucho. ";
        }

        private void textocarta_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnregresar_Click(object sender, EventArgs e)
        {

        }

        private void Formcarta_Load(object sender, EventArgs e)
        {

        }
    }
}
