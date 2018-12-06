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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_BuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                WSMonkys.WSBarClient servicio = new WSMonkys.WSBarClient();
                String usuario = tbx_usuario.Text;
                String pass = tbx_pass.Text;                
                String strCondicion = usuario + "'" + " and password='" + pass;
                String resultado = servicio.selectLogin(strCondicion);
                if (resultado != "Nombre de usuario o contraseña incorrectos")
                {
                    MessageBox.Show(resultado, "Sesión iniciada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 obj = new Form1();
                    this.Hide();
                    obj.Show();
                }
                else
                {
                    MessageBox.Show(resultado, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }       
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
