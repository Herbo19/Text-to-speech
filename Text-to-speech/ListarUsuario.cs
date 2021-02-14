using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;

namespace Text_to_speech
{
    public partial class ListarUsuario : DevComponents.DotNetBar.Metro.MetroForm
    {
        public ListarUsuario()
        {
            InitializeComponent();
        }

        private void BtLIstar_Click(object sender, EventArgs e)
        {
            String talis = "server = 127.0.0.1; port = 3306; database = usuario; Uid = root; Pwd =  ";
            MySqlConnection isaura = new MySqlConnection(talis);
            isaura.Open();
            MySqlCommand jsmp = new MySqlCommand("PCD_Listar_Usuario", isaura);
            jsmp.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter dapt = new MySqlDataAdapter(jsmp);
            DataTable ta = new DataTable();
            dapt.Fill(ta);
            DGListarUsuario.DataSource = ta;
        }
    }
}