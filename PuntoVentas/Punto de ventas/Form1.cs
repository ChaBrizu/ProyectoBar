using Punto_de_ventas.ModelsClass;
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
        TextBoxEvent evento = new TextBoxEvent();
        private string paginas = "4", accion = "insert", deudaActual, pago, dia, fecha; 
        public Form1()
        {
            InitializeComponent();
            /**********************************
             *                                *
             *   Codigo Ventas                *
             *                                *
             **********************************/
            #region
            
            #endregion
            /**********************************
             *                                *
             *   Codigo Ventas                *
             *                                *
             **********************************/
            #region
            button_Ventas.Enabled = false;
            #endregion
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
        /**********************************
         *                                *
         *   Codigo Ventas                *
         *                                *
         **********************************/
        #region

        private void button_Ventas_Click(object sender, EventArgs e)
        {
            paginas = "0";
            accion = "insert";

            //Llamamos a la pagina 1 del tabControl
            tabControl1.SelectedIndex = 0;
            //cargarDatos();
            button_Clientes.Enabled = true;
            button_Ventas.Enabled = false;
            button_Productos.Enabled = true;
            //button_Compras.Enabled = true;
            //button_Dpto.Enabled = true;
        }
        private void textBox_BuscarProductos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_BuscarProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.textKeyPress(e);
        }
        private void textBox_Cantidad_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Cantidad.Text == " ")
            {
                label_Cantidad.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_Cantidad.Text = "Cantidad";
                label_Cantidad.ForeColor = Color.Green;
            }
        }

        private void textBox_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.numberDecimalKeyPress(textBox_Cantidad,e);
        }
        private void textBox_Pagos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Pagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.numberDecimalKeyPress(textBox_Pagos,e);
        }
        #endregion
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
            //button_Compras.Enabled = true;
            //button_Dpto.Enabled = true;
            
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
            if(textBox_Id.Text == " ")
            {
                label_Id.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_Id.Text = "ID";
                label_Id.ForeColor = Color.Green;
            }
        }

        private void textBox_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.numberKeyPress(e);
        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Nombre.Text == " ")
            {
                label_Nombre.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_Nombre.Text = "Nombre Completo";
                label_Nombre.ForeColor = Color.Green;
            }
        }

        private void textBox_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.textKeyPress(e);
        }

        private void textBox_Apellido_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Apellido.Text == " ")
            {
                label_Apellido.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_Apellido.Text = "Apellido";
                label_Apellido.ForeColor = Color.Green;
            }
        }

        private void textBox_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.textKeyPress(e);
        }

        private void textBox_Direccion_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Direccion.Text == " ")
            {
                label_Direccion.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_Direccion.Text = "Dirección";
                label_Direccion.ForeColor = Color.Green;
            }
        }

        
        private void textBox_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
             
        }

        private void textBox_Telefono_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Telefono.Text == " ")
            {
                label_Telefono.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_Telefono.Text = "Telefono";
                label_Telefono.ForeColor = Color.Green;
            }
        }

        private void textBox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.numberKeyPress(e);
        }

        private void groupBox18_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_PagoscCliente_TextChanged(object sender, EventArgs e)
        {
            if (textBox_PagoscCliente.Text == " ")
            {
                label_PagoCliente.ForeColor = Color.LightSlateGray;
            }
            else
            {
                label_PagoCliente.Text = "Pagos de deudas";
                label_PagoCliente.ForeColor = Color.Green;
            }
        }

        

        private void textBox_PagoscCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.numberDecimalKeyPress(textBox_PagoscCliente,e);
        }

        private void button_GuardarCliente_Click(object sender, EventArgs e)
        {
            if (radioButton_IngresarCliente.Checked)
            {
                guardarCliente();
            }
        }

        private void guardarCliente()
        {
            if (textBox_Id.Text == " ")
            {
                label_Id.Text = "Ingrese el ID";
                label_Id.ForeColor = Color.Red;
                textBox_Id.Focus();
            }
            else
            {
                if (textBox_Nombre.Text == " ")
                {
                    label_Nombre.Text = "Ingrese el nombre completo";
                    label_Nombre.ForeColor = Color.Red;
                    textBox_Nombre.Focus();
                }
                else
                {
                    if (textBox_Apellido.Text == " ")
                    {
                        label_Apellido.Text = "Ingrese el apellido";
                        label_Apellido.ForeColor = Color.Red;
                        textBox_Apellido.Focus();
                    }
                    else
                    {
                        if (textBox_Direccion.Text == " ")
                        {
                            label_Direccion.Text = "Ingrese la direccion";
                            label_Direccion.ForeColor = Color.Red;
                            textBox_Direccion.Focus();
                        }
                        else
                        {
                            if (textBox_Telefono.Text == " ")
                            {
                                label_Telefono.Text = "Ingrese El numero de telefono";
                                label_Telefono.ForeColor = Color.Red;
                                textBox_Telefono.Focus();
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
        }
        #endregion
        /**********************************
         *                                *
         *   Codigo Productos             *
         *                                *
         **********************************/
        #region
        private void button_Productos_Click(object sender, EventArgs e)
        {
            paginas = "2";
            accion = "insert";

            //Llamamos a la pagina 1 del tabControl
            tabControl1.SelectedIndex = 2;
            //cargarDatos();
            button_Clientes.Enabled = true;
            button_Ventas.Enabled = true;
            button_Productos.Enabled = false;
            //button_Compras.Enabled = true;
            //button_Dpto.Enabled = true;
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.numberKeyPress(e);
        }
        private void textBox_DescripcionPDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.textKeyPress(e);
        }
        private void textBox_Canti_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.numberKeyPress(e);
        }
        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            evento.numberDecimalKeyPress(textBox_Price, e);
        }
        #endregion
    }
}
