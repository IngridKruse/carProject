using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prjPrefCar
{
    public partial class frmGerCadFunc : Form
    {
        static String c = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PrefCarBanco.mdf;Integrated Security=True;Connect Timeout=30";
        static string com;
        SqlConnection conecta = new SqlConnection(c);
        public frmGerCadFunc()
        {
            InitializeComponent();
        }

        private void frmGerCadFunc_Load(object sender, EventArgs e)
        {
            conecta.Open();

            if (conecta.State == System.Data.ConnectionState.Open)
            {
                com = "select Id, Nome, Cargo, Login, Status, ADM from Table_Funcionario where Status != 1";
                SqlCommand comando = new SqlCommand(com, conecta);
                comando.ExecuteNonQuery();
               
                SqlDataAdapter adp = new SqlDataAdapter(comando);
                
                DataTable table = new DataTable();
                adp.Fill(table);

                dataGridViewCadastro.DataSource = table;               
            }
            conecta.Close();
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            conecta.Open();
            foreach (DataGridViewRow row in dataGridViewCadastro.Rows)
            {
                String status;
                status = Convert.ToString(row.Cells["Status"].Value);

                if (status == "True")
                {
                    com = "update Table_Funcionario set Status = 1, ADM = 1 where Id = '" + row.Cells["Id"].Value + "'";
                    SqlCommand comando = new SqlCommand(com, conecta);
                    comando.ExecuteNonQuery();
                    
                }
            }
            conecta.Close();
            frmGerCadFunc_Load(sender, e);
        }

        private void btnReprovar_Click(object sender, EventArgs e)
        {
            conecta.Open();
            foreach (DataGridViewRow row in dataGridViewCadastro.Rows)
            {
                String status;
                status = Convert.ToString(row.Cells["Status"].Value);

                if (status == "True")
                {
                    com = "delete from Table_Funcionario where Id = '" + row.Cells["Id"].Value + "'";
                    SqlCommand comando = new SqlCommand(com, conecta);
                    comando.ExecuteNonQuery();

                }
            }
            conecta.Close();
            frmGerCadFunc_Load(sender, e);
        }
    }
}
