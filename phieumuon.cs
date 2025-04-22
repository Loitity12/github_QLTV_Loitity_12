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
    public partial class phieumuon : Form
    {
        private Form2 f2;
        private phieumuon f4;
        private phieumuon form4;

        public phieumuon(Form2 f2)
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;

            comboBox1.Items.Add("7");
            comboBox1.Items.Add("14");
            comboBox1.Items.Add("21");
        }

        public phieumuon(phieumuon form4)
        {
            this.form4 = form4;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox1.Text, out int soNgayMuon))
            {
                MessageBox.Show("Số ngày mượn: " + soNgayMuon);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ!");
            }
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phieumuon f4 = new phieumuon(this);
            this.Hide();
            f2.Show();
        }
    }
}
