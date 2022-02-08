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
    public partial class frmListarCarro : Form
    {
        static string seleec;
        static String c = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PrefCarBanco.mdf;Integrated Security=True;Connect Timeout=30";
        static string com;
        Boolean ADM;
        SqlConnection conecta = new SqlConnection(c);

        public frmListarCarro(Boolean ADM)
        {
            InitializeComponent();
            this.ADM = ADM;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadCarro cadcarro = new frmCadCarro();
            this.Hide();
            cadcarro.ShowDialog();
            this.Show();
            frmListarCarro_Load(sender, e);
        }

        private void frmListarCarro_Load(object sender, EventArgs e)
        {
            if(!(ADM == true))
            {
                button1.Visible = false;
                button2.Visible = false;
                button4.Visible = false;
            }
            
            conecta.Close();
            conecta.Open();

            if (conecta.State == System.Data.ConnectionState.Open)
            {
                com = "select Modelo, Cor, Placa from Table_Carros";
                SqlCommand comando = new SqlCommand(com, conecta);
                comando.ExecuteNonQuery();

                SqlDataAdapter adp = new SqlDataAdapter(comando);

                DataTable table = new DataTable();
                adp.Fill(table);

                dataGridViewListaCarros.DataSource = table;
            }
            conecta.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGerCadFunc ger = new frmGerCadFunc();
            this.Hide();
            ger.ShowDialog();  
            this.Show();
            frmListarCarro_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seleec = dataGridViewListaCarros.SelectedCells[2].Value.ToString();
            frmAlterarStatusCarro alt = new frmAlterarStatusCarro(seleec, ADM);
            this.Hide();
            alt.ShowDialog();
            this.Show();
            frmListarCarro_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = 
                dataGridViewListaCarros.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    seleec = dataGridViewListaCarros.SelectedCells[2].Value.ToString();
                    MessageBox.Show(seleec);
                    frmAgendar alt = new frmAgendar(seleec, ADM);
                    this.Hide();
                    alt.ShowDialog();
                    this.Show();
                    frmListarCarro_Load(sender, e);
                }
                
               // sb.Append("Total: " + selectedRowCount.ToString());
                //MessageBox.Show(" " + selec);
            }
            conecta.Close();
            // DataTable dt = new DataTable();
            // foreach(DataRow x in dataGridViewListaCarros.Rows)
            //{
            // MessageBox.Show(" " + dataGridViewListaCarros.Rows[0].Cells[0].Value.ToString());
            // MessageBox.Show(" " + dataGridViewListaCarros.SelectedRows.cells);
            //}
        }
    }
}
