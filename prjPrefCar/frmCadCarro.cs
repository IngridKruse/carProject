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
    public partial class frmCadCarro : Form
    {
        static String c = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PrefCarBanco.mdf;Integrated Security=True;Connect Timeout=30";
        static string com;
        SqlConnection conecta = new SqlConnection(c);
        public frmCadCarro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmCadCarro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conecta.Open();
            if (conecta.State == System.Data.ConnectionState.Open)
            {
                com = "insert into Table_Carros(Placa, Modelo, NumeroPortas, Marca, Cor, Status) " +
                    "values('" + txtPlaca.Text + "', '" + txtModelo.Text + "', '" + txtNumPortas.Text + "', '" + txtMarca.Text + "', '" + txtCor.Text + "', 'Disponivel')";
                SqlCommand comando = new SqlCommand(com, conecta);
                comando.ExecuteNonQuery();

                txtCor.Text = "";
                txtMarca.Text = "";
                txtModelo.Text = "";
                txtNumPortas.Text = "";
                txtPlaca.Text = "";

                MessageBox.Show("Carro cadastrado com sucesso!!!");
            }
            else
            {
                MessageBox.Show("Erro no cadastro");
            }
        }
    }
}
