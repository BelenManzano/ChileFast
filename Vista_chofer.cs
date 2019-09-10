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
    public partial class Vista_chofer : Form
    {
        public Vista_chofer()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from chofer",conexion);
            // creo un nuevo adaptador
            SqlDataAdapter adaptador = new SqlDataAdapter();
            // el adaptador ejecuta la consulta sql
            adaptador.SelectCommand = comando;
            // genero la tabla
            DataTable tabla = new DataTable();
            //agrego los datos a la tabla con fill
            adaptador.Fill(tabla);
            //finalmente asigno a el data grid
            dtaTable.DataSource = tabla;

        }
    }
}
