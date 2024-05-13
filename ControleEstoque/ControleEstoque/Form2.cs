using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ControleEstoque
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Principal.ActiveForm.Visible = false;
            
        }

        DataTable dt = new DataTable();
        Principal principal = new Principal();

        string aux = "";
//--------------------------------------------------------------------------

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            ofd.Filter = "Arquivos de Imagem|*.png;*.jpg;*.jpeg";
            ofd.Title = "Selecione um arquivo de imagem";
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = ofd.FileName;
                aux = path;
                if (path != "")
                {
                    Bitmap imagePath = new Bitmap(path);
                    pictureBox1.Load(path);

                }
                    
            }
            GC.Collect();

        }

//--------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            Principal.ActiveForm.Visible = true;
            Form2.ActiveForm.Visible = false;//
            principal.ShowDialog();

        }

//------------------------- FUNÇOES -------------------------------------------
       
        private void Cadastrar()
        {
            //-------------VARIAVEIS-------------

            string nome_produto = nomeProd_text.Text;
            string prod_cod = codProd_text.Text;
            int qtd_prod = int.Parse(qtdProd_text.Text);
            string marca_prod = marca_text.Text;
            string fam_prod = comboBox1.Text;
            string preco_prod = preco_text.Text;
            string data_receb = dateTimePicker1.Text;
            string fornec_prod = forn_prod.Text;
            string dado1_prod = dado1_text.Text;
            string dado2_prod = dado2_text.Text;
            string image_prod = aux;

            //-------------------------------------

            string SQL = $@"
                INSERT INTO PRODUTOS (P1_COD, P1_NOME, P1_QTD, P1_FAMILIA, P1_MARCA, P1_PRECO, P1_FORNECEDOR, P1_DATARECEB, P1_INFOAD1, P1_INFOAD2, P1_IMGPROD)
                VALUES (
                    '{prod_cod}',
                    '{nome_produto}',
                     {qtd_prod},
                    '{fam_prod}',
                    '{marca_prod}',
                     '{preco_prod}',
                    '{fornec_prod}',
                    '{data_receb}',
                    '{dado1_prod}',
                    '{dado2_prod}',
                    '{image_prod}');";

            string sql_estoque = $@"
                INSERT INTO ESTOQUE (CODIGO_DU, E1_QTDIN, E1_QTDOUT, E1_STATUS, E1_CATEGORIA, E1_DTSAIDA)
                VALUES ((SELECT CODIGOID FROM PRODUTOS WHERE P1_COD = '{prod_cod}'), {qtd_prod}, 0, 'DISPONIVEL', '{fam_prod}', '{data_receb}');";


            Banco.comandoSql(SQL);
            Banco.comandoSql(sql_estoque);
        }

//--------------------------------------------------------------------------

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //-------------CADASTRO BUTTON------------

        private void cadastrar_btn_Click(object sender, EventArgs e)
        {

            Cadastrar();

        }

//--------------------------------------------------------------------------

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.ShowDialog();

        }

//--------------------------------------------------------------------------

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            dado_label.Visible = dado1_text.Visible = true;
            dado2_label.Visible = dado2_text.Visible = true;

            switch (index)
            {
                case 0: // ALTO FALANTES
                    dado_label.Text = "Potência";
                    break;

                case 1: // ARMAZENAMENTO
                    dado_label.Text = "Capacidade:";
                    break;

                case 2: // CABO
                    dado_label.Text = "Comprimento:";
                    break;

                case 3: // FANS
                    dado_label.Text = "Tamanho:";
                    break;

                case 4: // FONES
                    dado_label.Text = "Tipo de fone:";
                    break;

                case 5: // FONTES
                    dado_label.Text = "Potência:";
                    break;

                case 6: // GABINETES
                    dado_label.Text = "Tamanho:";
                    break;

                case 7: // MEMORIA RAM
                    dado_label.Text = "Capacidade:";
                    break;

                case 8: // MONITOR
                    dado_label.Text = "Tamanho";
                    break;

                case 9: // MOUSE
                    dado_label.Text = "DPI:";
                    break;

                case 10: // MOUSEPADS
                    dado_label.Text = "Tamanho:";
                    break;

                case 11: // NOTEBOOKS
                    dado_label.Text = "Processador:";
                    break;

                case 12: // PLACA DE VIDEO
                    dado_label.Text = "Memória:";
                    break;

                case 13: // PLACA MAE
                    dado_label.Text = "Formato:";
                    break;

                case 14: // PROCESSADOR
                    dado_label.Text = "Velocidade:";
                    break;

                case 15: // SMARTPHONES
                    dado_label.Text = "Sistema operacional:";
                    break;

                case 16: // TECLADO
                    dado_label.Text = "Tipo:";
                    break;

                case 17: // VIDEOGAMES
                    dado_label.Text = "Marca:";
                    break;

                case 18: // WEBCAM
                    dado_label.Text = "Resolução:";
                    break;

                default:
                    MessageBox.Show("Por favor, selecione uma opção válida.", "Erro");
                    break;


            }
        }

//--------------------------------------------------------------------------

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal.ActiveForm.Visible = true;
            Form2.ActiveForm.Visible = false;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void qtdProd_text_Enter(object sender, EventArgs e)
        {
            qtdProd_text.KeyPress += (sender, e) =>
            {
                // Obtém o caractere pressionado
                char keyChar = e.KeyChar;

                // Permite apenas números (0-9), backspace e delete
                if (!char.IsControl(keyChar) && !char.IsDigit(keyChar))
                {
                    e.Handled = true; // Ignora o caractere digitado
                }
            };
        }

        private void preco_text_Enter(object sender, EventArgs e)
        {

            

            preco_text.KeyPress += (sender, e) =>
            {
                // Obtém o caractere pressionado
                char keyChar = e.KeyChar;

                // Permite apenas números (0-9), backspace e delete
                if (!char.IsControl(keyChar) && !char.IsDigit(keyChar))
                {
                    e.Handled = true; // Ignora o caractere digitado
                }
            };


        }

        private void preco_text_Leave(object sender, EventArgs e)
        {

            double aux = double.Parse(preco_text.Text);
            preco_text.Text = aux.ToString("C", CultureInfo.CurrentCulture);
            
        }

        private void nomeProd_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void preco_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void preco_text_Click(object sender, EventArgs e)
        {
            preco_text.SelectAll();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void codProd_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void qtdProd_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void marca_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void dado1_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void dado2_label_Click(object sender, EventArgs e)
        {

        }

        private void dado2_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void forn_prod_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }
}
