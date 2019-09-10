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
    public partial class Valijas : Form
    {
        public Valijas()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conexion.Open();
            string marca = txtMarca.Text;
            string largo = txtLargo.Text;
            string delicado = cmbDelicado.Text;
            string peso = txtPeso.Text;
            string altura = txtAltura.Text;
            string ancho = txtAncho.Text;
            string color = txtColor.Text;
            string comentario = txtComentario.Text;
            if (string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(delicado) || string.IsNullOrEmpty(comentario) || string.IsNullOrEmpty(color))
            {
                MessageBox.Show("Debes completar los campos vacios");
            }
            else
            {
                string cadena = "insert into Valijas(peso,altura,ancho,marca,color,largo,delicado,comentario)" +
                "values (" + peso + "," + altura + "," + ancho + ",'" + marca + "','" + color + "'," + largo + ",'" + delicado + "','" + comentario + "')";

                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente");
                conexion.Close();
                MessageBox.Show("Aviso de prueba : Se cerró la conexión.");
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form vista_valija = new Vista_valijas();
            vista_valija.Show();
        }
    }
}
