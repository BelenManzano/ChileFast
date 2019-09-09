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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conexion.Open();
            string rut = txtRut.Text;
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;

            if (string.IsNullOrEmpty(rut) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Debes completar los campos vacios");
            }
            else
            {
                string consulta = "insert into cliente(rut,nombre,correo,telefono)" +
                                "values (" + rut + ",'" + nombre + "','" + correo + "'," + telefono + ")";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente");
                conexion.Close();
                MessageBox.Show("Aviso de prueba : Se cerró la conexión.");
            }

            

        }
    }
}
