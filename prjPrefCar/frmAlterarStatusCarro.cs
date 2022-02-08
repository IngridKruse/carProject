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
    public partial class frmAlterarStatusCarro : Form
    {
        static String c = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PrefCarBanco.mdf;Integrated Security=True;Connect Timeout=30";
        static string com;
        SqlConnection conecta = new SqlConnection(c);
        static String x;
        String seelec;
        Boolean ADM;
        public frmAlterarStatusCarro(string seelec, Boolean ADM)
        {
            InitializeComponent();
            this.seelec = seelec;
            this.ADM = ADM;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAlterarStatusCarro_Load(object sender, EventArgs e)
        {
            conecta.Open();

            if (conecta.State == System.Data.ConnectionState.Open)
            {
                com = "select Modelo, Status from Table_Carros where Placa = '"+seelec+"'";
                SqlCommand comando = new SqlCommand(com, conecta);
                comando.ExecuteNonQuery();
                SqlDataReader read = comando.ExecuteReader();
                // while(read.Read())
                // {
                read.Read();
                lbl_Modelo.Text = read[1].ToString();
                if (read[1].ToString() == "Disponivel")
                {
                    rdb_Disponivel.Checked = true;
                }
                else if (read[1].ToString() == "Em Conserto")
                {
                    rdb_EmConcerto.Checked = true;
                }
                else if (read[1].ToString() == "Em Uso")
                {
                    rdb_EmUso.Checked = true;
                }
                else if (read[1].ToString() == "Quebrado")
                {
                    rdb_Quebrado.Checked = true;
                }
                //  }
                // lbl_Modelo.Text = comando.ExecuteReader(0);

            }
            conecta.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conecta.Open();
            
            if (conecta.State == System.Data.ConnectionState.Open)
            {
                if(rdb_Disponivel.Checked == true)
                {
                    x = "Disponivel";
                }
                else if(rdb_EmConcerto.Checked == true)
                {
                    x = "Em Conserto";
                }
                else if(rdb_EmUso.Checked == true)
                {
                    x = "Em Uso";
                }
                else if(rdb_Quebrado.Checked == true)
                {
                    x = "Quebrado";
                }
                com = "update Table_Carros set Status = '"+x+"' where  Placa = '"+seelec+"'";
                SqlCommand comando = new SqlCommand(com, conecta);
                comando.ExecuteNonQuery();
            }
            conecta.Close();
            frmListarCarro list = new frmListarCarro(ADM);
            Close();
            list.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
