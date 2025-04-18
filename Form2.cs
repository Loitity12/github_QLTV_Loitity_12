using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace DANG_NHAP
{
    public partial class Form2 : Form
    {
        private Form1 f1;
        

        public Form2(Form1 f1)
        {
            InitializeComponent();
            textBox1.Text = "Bạn muốn tìm gì?";
            textBox1.ForeColor = System.Drawing.Color.Gray;
            textBox1.Enter += (s, e) =>
            {
                if (textBox1.Text == "Bạn muốn tìm gì?")
                {
                    textBox1.Text = "";
                    textBox1.ForeColor = System.Drawing.Color.Black;
                }
            };
            textBox1.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    textBox1.Text = "Bạn muốn tìm gì?";
                    textBox1.ForeColor = System.Drawing.Color.Gray;
                }
            };
            this.f1 = f1;

            button1.Enabled = true;
            DTG1.SelectionChanged += DTG1_SelectionChanged;

        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }

        private void cHÍNHSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string policy = "Chúng tôi cam kết bảo vệ thông tin cá nhân của bạn. " +
                    "Mọi dữ liệu thu thập sẽ chỉ được sử dụng để cải thiện trải nghiệm người dùng " +
                    "và sẽ không được chia sẻ với bên thứ ba nếu không có sự đồng ý của bạn." + "\n" +
                    "Bản quyền thuộc về Loirecord(CONCAK.NET)";
            MessageBox.Show(policy, "Chính sách quyền riêng tư");
        }

        private void DTG1_SelectionChanged(object sender, EventArgs e)
        {
            if (DTG1.SelectedRows.Count > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn mượn quyển sách trên không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Form4 f4=new Form4(this);
            this.Hide();
            f4.Show();
        }
    }
}
