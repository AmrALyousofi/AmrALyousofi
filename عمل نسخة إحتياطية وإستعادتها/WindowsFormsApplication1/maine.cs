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
    public partial class maine : Form
    {
        public maine()
        {
            InitializeComponent();
        }

        private void النسخالإحياطيللنظامToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
