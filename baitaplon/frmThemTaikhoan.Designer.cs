namespace baitaplon
{
    partial class frmThemTaikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTaikhoan));
            label7 = new Label();
            panel1 = new Panel();
            txtQuyen = new TextBox();
            label4 = new Label();
            txtTentk = new TextBox();
            lable = new Label();
            txtPass = new TextBox();
            label2 = new Label();
            txtID_User = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnThoat = new Button();
            btnLuu = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(76, 36);
            label7.Name = "label7";
            label7.Size = new Size(487, 38);
            label7.TabIndex = 30;
            label7.Text = "NHẬP THÔNG TIN TÀI KHOẢN MỚI";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(txtQuyen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTentk);
            panel1.Controls.Add(lable);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtID_User);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 159);
            panel1.TabIndex = 31;
            // 
            // txtQuyen
            // 
            txtQuyen.Location = new Point(472, 104);
            txtQuyen.Name = "txtQuyen";
            txtQuyen.Size = new Size(125, 27);
            txtQuyen.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 111);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 6;
            label4.Text = "Quyền";
            // 
            // txtTentk
            // 
            txtTentk.Location = new Point(472, 25);
            txtTentk.Name = "txtTentk";
            txtTentk.Size = new Size(125, 27);
            txtTentk.TabIndex = 5;
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Location = new Point(363, 32);
            lable.Name = "lable";
            lable.Size = new Size(97, 20);
            lable.TabIndex = 4;
            lable.Text = "Tên tài khoản";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(146, 104);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(125, 27);
            txtPass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 111);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // txtID_User
            // 
            txtID_User.Location = new Point(146, 25);
            txtID_User.Name = "txtID_User";
            txtID_User.Size = new Size(125, 27);
            txtID_User.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 32);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "ID_User";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 255);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnLuu);
            panel2.Location = new Point(649, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 159);
            panel2.TabIndex = 32;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(52, 93);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(138, 48);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(52, 12);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(138, 48);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // frmThemTaikhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label7);
            Name = "frmThemTaikhoan";
            Text = "THÊM TÀI KHOẢN MỚI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Panel panel1;
        private TextBox txtQuyen;
        private Label label4;
        private TextBox txtTentk;
        private Label lable;
        private TextBox txtPass;
        private Label label2;
        private TextBox txtID_User;
        private Label label1;
        private Panel panel2;
        private Button btnLuu;
        private Button btnThoat;
    }
}