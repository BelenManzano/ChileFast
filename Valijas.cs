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
            string venta = txtVenta.Text;
            string marca = txtMarca.Text;
            string largo = txtLargo.Text;
            string delicado = cmbDelicado.Text;
            string peso = txtPeso.Text;
            string altura = txtAltura.Text;
            string ancho = txtAncho.Text;
            string color = txtColor.Text;
            string comentario = txtComentario.Text;

            string cadena = "insert into Valijas(id,peso,altura,anchura,marca,color,largo,delicado,comentario)" +
            "values ("+venta+","+ peso + "," + altura + "," + ancho + ",'"+marca+"','" + color + "',"+largo+",'"+delicado+"','" + comentario + "')";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            conexion.Close();
            MessageBox.Show("Aviso de prueba : Se cerró la conexión.");
        }

        
    }
}
