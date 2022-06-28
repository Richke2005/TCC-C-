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
    public partial class esqueci : Form
    {
        public esqueci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "vinicius.vieira62@etec.sp.gov.br") ;
                popupes OutroForm = new popupes();
                OutroForm.ShowDialog();
                Close();
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Código de recuperação enviado com sucesso");
        }
        

        
    

    
    

