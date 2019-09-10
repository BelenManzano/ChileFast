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
    public partial class Vista_clientes : Form
    {
        public Vista_clientes()
        {
            InitializeComponent();
        }

        private void TxtMostrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from cliente", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtaTable.DataSource = tabla;
        }

        private void DtaTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtaTable.CurrentRow.Cells[0].Value.ToString();
            txtRut.Text = dtaTable.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dtaTable.CurrentRow.Cells[2].Value.ToString();
            txtCorreo.Text = dtaTable.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dtaTable.CurrentRow.Cells[4].Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conexion.Open();
            string query = "DELETE FROM cliente WHERE id = @id";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", txtID.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("se elimino correctamente");
        }
    }
}
