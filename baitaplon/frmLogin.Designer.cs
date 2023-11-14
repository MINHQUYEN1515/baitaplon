namespace baitaplon
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new Panel();
            txtPass = new TextBox();
            label2 = new Label();
            txtTendangnhap = new TextBox();
            label1 = new Label();
            label7 = new Label();
            btnDangnhap = new Button();
            btnThoat = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTendangnhap);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(302, 22);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 224);
            panel1.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(150, 124);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(196, 23);
            txtPass.TabIndex = 35;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 122);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 34;
            label2.Text = "Mật khẩu";
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.Location = new Point(150, 72);
            txtTendangnhap.Margin = new Padding(3, 2, 3, 2);
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.Size = new Size(196, 23);
            txtTendangnhap.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 69);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 32;
            label1.Text = "Tên đăng nhập";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(24, 18);
            label7.Name = "label7";
            label7.Size = new Size(275, 30);
            label7.TabIndex = 31;
            label7.Text = "THÔNG TIN ĐĂNG NHẬP";
            label7.Click += label7_Click;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangnhap.Location = new Point(326, 262);
            btnDangnhap.Margin = new Padding(3, 2, 3, 2);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(133, 57);
            btnDangnhap.TabIndex = 1;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(514, 262);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(133, 57);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 22);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 224);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnDangnhap);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "ĐĂNG NHẬP HỆ THỐNG";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private TextBox txtPass;
        private Label label2;
        private TextBox txtTendangnhap;
        private Label label1;
        private Button btnDangnhap;
        private Button btnThoat;
        private PictureBox pictureBox1;
    }
}