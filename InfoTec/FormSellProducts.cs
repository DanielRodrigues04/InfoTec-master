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
    public partial class FormSellProducts : Form
    {
        MySqlConnection Conexao;

        Boolean isEditTextChanged = new Boolean();


        public FormSellProducts()
        {
            InitializeComponent();
        }

        private void FormSellProducts_Load(object sender, EventArgs e)
        {
            isEditTextChanged = false;
        }

       
        private void registerProduct_Click(object sender, EventArgs e)
        {
         
        }

        private void idProductEditText_TextChanged(object sender, EventArgs e)
        {
            isEditTextChanged = true;
        }

        private void cadastroBtn_Click(object sender, EventArgs e)
        {

            try

            {
                string data_source = "datasource=localhost;username=root;password=10203040d;database=infotec";

                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                string sql = " DELETE FROM produtos WHERE id ='"+idProductEditText.Text +"'; ";

               

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                comando.ExecuteReader();
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }


           

            if (isEditTextChanged)
            {
                FormDialogSuccess successDialog = new FormDialogSuccess();
                successDialog.ShowDialog();
            }
        }

        private void NovoProduto_Click(object sender, EventArgs e)
        {

        }
    }
}
