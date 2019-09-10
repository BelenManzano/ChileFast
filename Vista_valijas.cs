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
    public partial class Vista_valijas : Form
    {
        public Vista_valijas()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from valijas", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtaTable.DataSource = tabla;
        }

        private void DtaTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtaTable.CurrentRow.Cells[0].Value.ToString();
            txtPeso.Text = dtaTable.CurrentRow.Cells[1].Value.ToString();
            txtAltura.Text = dtaTable.CurrentRow.Cells[2].Value.ToString();
            txtAncho.Text = dtaTable.CurrentRow.Cells[3].Value.ToString();
            txtMarca.Text = dtaTable.CurrentRow.Cells[4].Value.ToString();
            txtColor.Text = dtaTable.CurrentRow.Cells[5].Value.ToString();
            txtLargo.Text = dtaTable.CurrentRow.Cells[6].Value.ToString();
            cmbDelicado.Text = dtaTable.CurrentRow.Cells[7].Value.ToString();
            txtComentario.Text = dtaTable.CurrentRow.Cells[8].Value.ToString();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            conexion.Open();
            string query = "DELETE FROM Valijas WHERE id = @id";
            SqlCommand comando = new SqlCommand(query, conexion);
            // le asigno el valor de id a la variable de la consulta
            comando.Parameters.AddWithValue("@id", txtId.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("se elimino correctamente");
        }
    }
}
