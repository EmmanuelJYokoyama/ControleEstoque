using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Principal.ActiveForm.Visible = false;
        }

        Principal principal = new Principal();

        private void nomeProd_text_TextChanged(object sender, EventArgs e)
        {
            //BEGIN CODE
        }

        private void qtdProd_text_TextChanged(object sender, EventArgs e)
        {
            //update code here

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal.ActiveForm.Visible = true;
            Form3.ActiveForm.Visible = false;
            principal.ShowDialog();
        }

        private void codProd_text_Leave(object sender, EventArgs e)
        {

        }
    }
}
