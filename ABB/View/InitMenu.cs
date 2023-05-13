using ABB.Model;
using System;
using System.Windows.Forms;

namespace ABB.View
{
    public partial class InitMenu : Form
    {
        public InitMenu()
        {
            InitializeComponent();
        }

        //Invocacion del escenario pasando parametros de escenario 1
        private void btnPrimerEsc_Click(object sender, EventArgs e)
        {
            new Escenary(this, Escenario.ESCENARIO_UNO).Show();
            Hide();
        }

        //Invocacion del escenario pasando parametros de escenario 2
        private void btnSegundoEsc_Click(object sender, EventArgs e)
        {
            new Escenary(this, Escenario.ESCENARIO_DOS).Show();
            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de salir",
                                "¡Adevertencia!",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void InitMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
