using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyrtyvshin
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieForm mo = new MovieForm();
            mo.MdiParent = this;
            mo.Show();
        }

        private void commentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StarForm st = new StarForm();
            st.MdiParent = this;
            st.Show();

        }
    }
}
