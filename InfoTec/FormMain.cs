using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace InfoTec
{
    public partial class FormMain : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=10203040d;database=infotec";
        public FormMain()
        {
            InitializeComponent();

            listViewProducts.View = View.Details;
            listViewProducts.LabelEdit = true;
            listViewProducts.AllowColumnReorder = true;
            listViewProducts.FullRowSelect = true;
            listViewProducts.GridLines = true;



            listViewProducts.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("nome", 80, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("descricao", 200, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("preço", 80, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("qtd", 80, HorizontalAlignment.Left);



        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSellProducts sellProductsDialog = new FormSellProducts();
            sellProductsDialog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formRegisterDialog = new Form1();
            formRegisterDialog.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMensalReport reportDialog = new FormMensalReport();
            reportDialog.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try

            {

                string q = "'%" + BuscaTxt.Text + "%'";


                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * FROM produtos WHERE nome LIKE " + q ;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();  

                listViewProducts.Items.Clear();

                while(reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                         reader.GetString(1),
                          reader.GetString(2),
                           reader.GetString(3),
                            reader.GetString(4),

                    };
                    var linha_listview = new ListViewItem(row);

                    listViewProducts.Items.Add(linha_listview);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close(); // fecha a conexão com o DB
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
