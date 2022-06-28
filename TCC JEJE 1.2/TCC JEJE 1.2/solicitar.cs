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
    public partial class solicitar : Form
    {
        public solicitar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n OutroForm = new n();
            OutroForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s OutroForm = new s();
            OutroForm.ShowDialog();
            Close();
        }
    }
}
