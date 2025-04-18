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
    public partial class Form4 : Form
    {
        private Form2 f2;
        private Form4 f4;
        private Form4 form4;

        public Form4(Form2 f2)
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;

            comboBox1.Items.Add("7");
            comboBox1.Items.Add("14");
            comboBox1.Items.Add("21");
        }

        public Form4(Form4 form4)
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
            Form4 f4 = new Form4(this);
            this.Hide();
            f2.Show();
        }
    }
}
