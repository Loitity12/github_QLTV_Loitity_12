namespace DANG_NHAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.UseSystemPasswordChar = !textBox6.UseSystemPasswordChar;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yêu cầu cấp lại mật khẩu của bạn thành công. Một mật khẩu mới đã đc gửi đến số điện thoại(Mail) của bạn. Vui lòng kiểm tra lại và thay đổi mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.UseSystemPasswordChar = !textBox7.UseSystemPasswordChar;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form2 F2 = new Form2(this);
                F2.Show();
                this.Hide();
            }
            else if (radioButton2.Checked)
            {
                Form3 F3 = new Form3(this);
                F3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui long chon loai tai khoan truoc khi dang nhap!","Thong bao",MessageBoxButtons.OKCancel,MessageBoxIcon.Error );
            }
        }
    }
}
