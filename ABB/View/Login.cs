using ABB.Util;
using ABB.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Login();
            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage($"Ha ocurrido un error al iniciar sesión {ex}");
            }
        }

        private void Login()
        {
            Dictionary<String, object> password = new Dictionary<String, object> { { "la contraseña", txtContrasenia } };
            if (Utils.ValidateControls(password))
            {
                if (txtContrasenia.Text == "unad")
                {
                    Utils.ShowSuccesMessage("Contraseña correcta");
                    new InitMenu().Show();
                    Hide();
                }
                else
                {
                    Utils.ShowErrorMessage("Contraseña incorrecta");
                    txtContrasenia.Clear();
                }
            }
            txtContrasenia.Focus();
        }

        //KeyListener para tecla Enter
        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Login();
            }
        }
    }
}
