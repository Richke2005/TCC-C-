using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_JEJE_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="vinicius.vieira62@etec.sp.gov.br" &&textBox2.Text=="12345")
            {
                MessageBox.Show("Bem Vindo!");
                Form2 OutroForm = new Form2();
                OutroForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos.");

            }
            
        }

        private void  button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            esqueci OutroForm = new esqueci();
            OutroForm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }
    }
}
