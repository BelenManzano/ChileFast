﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChileFast
{
    public partial class Envio : Form
    {
        public Envio()
        {
            InitializeComponent();
        }

        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=chilefast;UID=root;PASSWORDS=;";
        MySqlConnection cn = new MySqlConnection(conexion);

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
