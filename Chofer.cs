using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChileFast
{
    public partial class Chofer : Form
    {
        public Chofer()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conexion.Open();
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string licencia = cmbLicencia.Text;
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(licencia))
            {
                MessageBox.Show("Debes completar los campos vacios");
            }
            else
            {
                string cadena = "insert into chofer(nombre,correo,telefono,licencia)" +
                "values ('" + nombre + "','" + correo + "'," + telefono + ",'" + licencia + "')";

                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente");
                conexion.Close();
                MessageBox.Show("Aviso de prueba : Se cerró la conexión.");
            }

        }

        private void BtnVista_Click(object sender, EventArgs e)
        {
            Form vista_chofer = new Vista_chofer();
            vista_chofer.Show();
        }
    }
}
