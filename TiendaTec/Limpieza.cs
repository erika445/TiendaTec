using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaTec
{
    internal class Limpieza
    {
        // Limpia las cajas de texto de manera automática
        public static void LimpiarCajas(GroupBox gb)
        {
            foreach (Control control in gb.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }
    }
}
