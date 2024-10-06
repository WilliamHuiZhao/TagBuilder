using System;
using System.Windows.Forms;

namespace TagBuilder
{
    public partial class TagBuilderMainForm : Form
    {
        public TagBuilderMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kepwareTagBuilderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KepwareTagBuilder dlgTag = new KepwareTagBuilder();
            dlgTag.ShowDialog();
        }
    }
}
