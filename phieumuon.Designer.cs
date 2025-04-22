namespace DANG_NHAP
{
    partial class phieumuon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tRANGCHỦToolStripMenuItem = new ToolStripMenuItem();
            tHOÁTToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tRANGCHỦToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(535, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tRANGCHỦToolStripMenuItem
            // 
            tRANGCHỦToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tHOÁTToolStripMenuItem });
            tRANGCHỦToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tRANGCHỦToolStripMenuItem.Name = "tRANGCHỦToolStripMenuItem";
            tRANGCHỦToolStripMenuItem.Size = new Size(143, 27);
            tRANGCHỦToolStripMenuItem.Text = "TRANG CHỦ";
            // 
            // tHOÁTToolStripMenuItem
            // 
            tHOÁTToolStripMenuItem.Name = "tHOÁTToolStripMenuItem";
            tHOÁTToolStripMenuItem.Size = new Size(224, 28);
            tHOÁTToolStripMenuItem.Text = "THOÁT";
            tHOÁTToolStripMenuItem.Click += tHOÁTToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 338);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(229, 266);
            button1.Name = "button1";
            button1.Size = new Size(162, 47);
            button1.TabIndex = 5;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(179, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(179, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 28);
            comboBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 27);
            textBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 208);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 1;
            label5.Text = "Ngày hẹn trả";
            label5.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 166);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 1;
            label4.Text = "Số ngày mượn";
            label4.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 119);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 1;
            label3.Text = "Số thẻ thư viện";
            label3.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 70);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên người mượn";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 19);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU MƯỢN";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 380);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form4";
            Text = "THƯ VIỆN";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tRANGCHỦToolStripMenuItem;
        private ToolStripMenuItem tHOÁTToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}