using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANG_NHAP
{
    public partial class Form3 : Form
    {
        private Form1 f1;
        private Form5 form5;

        public Form3(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }

        private void mƯỢNTRẢSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(this, "MuonTraSach");
            this.Close();
            f5.Show();
        }

        private void tHẺTHƯVIỆNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(this, "TheThuVien");
            this.Close();
            f5.Show();
        }

        private void tHỐNGKÊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(this, "ThongKe");
            this.Close();
            f5.Show();
        }
    }
}
