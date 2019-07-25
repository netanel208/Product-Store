using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class menuworker : Form
    {
        public menuworker()
        {
            InitializeComponent();
        }

        private void הצגפריטיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Item i = new Item();
            i.Show();
        }

        private void קניהמהספקToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menusales_Click(object sender, EventArgs e)
        {
            sales i = new sales();
            i.Show();
        }

        private void menuclient_Click(object sender, EventArgs e)
        {
            Form2 i = new Form2();
            i.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
