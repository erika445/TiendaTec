using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TiendaTec
{
    
    public partial class dgvCategoriaProductos : Form
    {
        int idCategoria;
        DataClasses1DataContext data = new DataClasses1DataContext();

        public dgvCategoriaProductos()
        {
            InitializeComponent();
           
        }
        private void dgvCategoriaProductos_Load(object sender, EventArgs e)
        {
            // Al cargar el formulario, mostramos los datos en el DataGridView
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            // Llamamos al procedimiento almacenado para obtener los datos
            dataCategoriaProductos.DataSource = data.MostrarCategoriaProducto();
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Verificar si los TextBox están vacíos
            if (string.IsNullOrEmpty(txtNombreCategoria.Text) || string.IsNullOrEmpty(txtDescripcionCategoria.Text))
            {
                MessageBox.Show("Por favor, ingresa valores en todos los campos.");
                return; // Salir del evento si algún TextBox está vacío
            }
            string msg = string.Empty;
            data.InsertarCategoriaProducto(txtNombreCategoria.Text, txtDescripcionCategoria.Text, ref msg);
            MessageBox.Show(msg);
            dataCategoriaProductos.DataSource = data.MostrarCategoriaProducto();

            // Limpiar TextBox después de insertar
            Limpieza.LimpiarCajas(gbCategoriaProductos);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
           dataCategoriaProductos.DataSource = data.MostrarCategoriaProducto();    
        }

      

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            data.BorrarCategoriaProducto(idCategoria,ref msg);
            MessageBox.Show(msg);
            dataCategoriaProductos.DataSource = data.MostrarCategoriaProducto();

            // Limpiar TextBox después de insertar
            Limpieza.LimpiarCajas(gbCategoriaProductos);
            btnBorrar.Enabled = false;
            btnActualizar.Enabled = false;  
        }

        private void dataCategoriaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
      

        }

        private void dataCategoriaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el clic fue en una celda válida (no en los encabezados)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow selectedRow = dataCategoriaProductos.Rows[e.RowIndex];

                // Aquí puedes acceder a los datos de cada celda en la fila
                // Por ejemplo, si la primera columna contiene el nombre:
                txtNombreCategoria.Text = selectedRow.Cells["nombreCategoria"].Value.ToString();
                txtDescripcionCategoria.Text = selectedRow.Cells["descripcionCategoria"].Value.ToString();
                idCategoria= Convert.ToInt32(selectedRow.Cells["claveCategoria"].Value);
                btnActualizar.Enabled = true;
                btnBorrar.Enabled = true;   
                // Realizar acciones con los datos obtenidos
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            data.ActualizarCategoriaProducto(idCategoria, txtNombreCategoria.Text, txtDescripcionCategoria.Text, ref msg);
            MessageBox.Show(msg);
            dataCategoriaProductos.DataSource = data.MostrarCategoriaProducto();

            // Limpiar TextBox después de insertar
            Limpieza.LimpiarCajas(gbCategoriaProductos);
            btnBorrar.Enabled = false;
            btnActualizar.Enabled = false;
        }
    }
}
