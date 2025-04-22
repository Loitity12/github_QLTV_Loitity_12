namespace DANG_NHAP
{
    partial class dangnhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(37, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(576, 346);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(294, 143);
            button2.Name = "button2";
            button2.Size = new Size(26, 27);
            button2.TabIndex = 4;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(326, 141);
            button1.Name = "button1";
            button1.Size = new Size(113, 29);
            button1.TabIndex = 3;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 216);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 2;
            label4.Text = "Bạn quên mật khẩu?";
           
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 27);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(76, 150);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 0;
            label2.Text = "PASSWORD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(220, 51);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 0;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(76, 115);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "USERNAME";
            // 
            // dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 776);
            Controls.Add(groupBox1);
            Name = "dangnhap";
            Text = "THƯ VIỆN";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label4;
    }
}
