using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_diferentes.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_email.Clear();
            maks_cpf.Clear();
            mask_telefone.Clear();
            tx_confsenha.Clear();
            tx_senha.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string senha = tx_senha.Text;   
            string consenha = tx_confsenha.Text;
            
            if(senha == consenha)
            {
                string nome = tx_nome.Text;
                string email = tx_email.Text;
                string cpf = maks_cpf.Text;
                string telefone = mask_telefone.Text;
                MessageBox.Show(nome + "\n" + cpf + "\n" + email + "\n" + telefone + "\n" + senha + "\n" + consenha);
                lb_diferentes.Text = "";
            }
            else
            {
                lb_diferentes.Text = "As senhas não coicidem!!";
            }
           ;

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tx_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
