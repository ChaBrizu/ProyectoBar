using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_ventas
{
    public partial class Form1 : Form
    {
        private string paginas = "4", accion = "insert", deudaActual, pago, dia, fecha; 
        public Form1()
        {
            InitializeComponent();
            /**********************************
             *                                *
             *   Codigo Cliente               *
             *                                *
             **********************************/
            #region
            radioButton_IngresarCliente.Checked = true;
            radioButton_IngresarCliente.ForeColor = Color.DarkCyan;
            #endregion
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }


        private void button_Config_Click(object sender, EventArgs e)
        {

        }

        

        private void button_Ventas_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
             
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }
        /**********************************
         *                                *
         *   Codigo Cliente               *
         *                                *
         **********************************/
        #region
        private void button_Clientes_Click(object sender, EventArgs e)
        {
            paginas = "1";
            accion = "insert";

            //Llamamos a la pagina 1 del tabControl
            tabControl1.SelectedIndex = 1;
            //cargarDatos();
            button_Clientes.Enabled = false;
            button_Ventas.Enabled = true;
            button_Productos.Enabled = true;
            button_Compras.Enabled = true;
            button_Dpto.Enabled = true;
            
        }
        private void radioButton_IngresarCliente_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_IngresarCliente.ForeColor = Color.DarkCyan;
            radioButton_PagosDeudas.ForeColor = Color.Black;

            textBox_Nombre.ReadOnly = false;
            textBox_Apellido.ReadOnly = false;
            textBox_Direccion.ReadOnly = false;
            textBox_Telefono.ReadOnly = false;
            textBox_PagoscCliente.ReadOnly = true;
            label_PaginasCliente.Text = "Pagos de deudas";
            label_PaginasCliente.ForeColor = Color.DarkCyan;
        }
        private void radioButton_PagosDeudas_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_IngresarCliente.ForeColor = Color.Black;
            radioButton_PagosDeudas.ForeColor = Color.DarkCyan;

            textBox_Nombre.ReadOnly = true;
            textBox_Apellido.ReadOnly = true;
            textBox_Direccion.ReadOnly = true;
            textBox_Telefono.ReadOnly = true;
            textBox_PagoscCliente.ReadOnly = false;
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Id_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_Direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_PagoscCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_PagoscCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        #endregion
    }
}
