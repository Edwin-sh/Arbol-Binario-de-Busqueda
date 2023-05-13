using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ABB.Util
{
    internal class Utils
    {
        /* Método que valida que se hayan ingresado valores en cada control
         * y recibe un diccionario con los controles a evaluar
         */
        public static bool ValidateControls(Dictionary<string, object> keyValues)
        {
            //Bandera inicial para estado de vacio o no
            bool noVacio = true;

            // Recorre cada elemento del diccionario
            foreach (KeyValuePair<string, object> valor in keyValues.ToArray())
            {

                // Compara el tipo de valor que contiene la iteración del bucle
                switch (valor.Value)
                {
                    case TextBox _:
                        noVacio = ValidateTextBox((TextBox)valor.Value, valor.Key);
                        break;
                    default:
                        break;
                }
                if (noVacio == false)
                {
                    return false;
                }
            }
            return noVacio;

        }
        //Método para validar el campo de texto
        private static bool ValidateTextBox(TextBox textBox, string nombreCampo)
        {
            if (textBox.Text.Length == 0)
            {
                MessageBox.Show($"Ingrese {nombreCampo} intentelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowSuccesMessage(string message)
        {
            MessageBox.Show(message, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
