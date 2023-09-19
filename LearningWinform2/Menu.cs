using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningWinform2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void doiMauXanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.SourceControl.BackColor = Color.Green;
        }

        private void doiMauDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.SourceControl.BackColor = Color.Red;
        }
    }
}
