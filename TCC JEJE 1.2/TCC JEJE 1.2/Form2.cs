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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void semana1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (contato uu = new _2.contato())
            {
                uu.ShowDialog();
            }
        }

        private void solicitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solicitar OutroForm = new solicitar();
            OutroForm.ShowDialog();
        }

        private void avaliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avaliar OutroForm = new avaliar();
            OutroForm.ShowDialog();
        }
    }
}
