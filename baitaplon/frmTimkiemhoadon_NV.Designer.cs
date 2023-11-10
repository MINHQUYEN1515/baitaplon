namespace baitaplon
{
    partial class frmTimhoadon_Nhanvien
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
            panel1 = new Panel();
            cbSelect = new ComboBox();
            label9 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            DGVhoadon = new DataGridView();
            label8 = new Label();
            txtngaysinh = new TextBox();
            txtchucvu = new TextBox();
            txtTen = new TextBox();
            txthsl = new TextBox();
            txtmaphong = new TextBox();
            txtphai = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVhoadon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(cbSelect);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(23, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            // 
            // cbSelect
            // 
            cbSelect.FormattingEnabled = true;
            cbSelect.Location = new Point(56, 53);
            cbSelect.Name = "cbSelect";
            cbSelect.Size = new Size(151, 28);
            cbSelect.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(23, 18);
            label9.Name = "label9";
            label9.Size = new Size(196, 20);
            label9.TabIndex = 0;
            label9.Text = "Chọn / Nhập mã nhân viên";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(23, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(138, 31);
            button2.Name = "button2";
            button2.Size = new Size(109, 60);
            button2.TabIndex = 1;
            button2.Text = "THOÁT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(3, 31);
            button1.Name = "button1";
            button1.Size = new Size(109, 60);
            button1.TabIndex = 0;
            button1.Text = "TÌM KIẾM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Violet;
            panel3.Controls.Add(DGVhoadon);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtngaysinh);
            panel3.Controls.Add(txtchucvu);
            panel3.Controls.Add(txtTen);
            panel3.Controls.Add(txthsl);
            panel3.Controls.Add(txtmaphong);
            panel3.Controls.Add(txtphai);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(279, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 488);
            panel3.TabIndex = 2;
            // 
            // DGVhoadon
            // 
            DGVhoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVhoadon.Location = new Point(3, 299);
            DGVhoadon.Name = "DGVhoadon";
            DGVhoadon.RowHeadersWidth = 51;
            DGVhoadon.RowTemplate.Height = 29;
            DGVhoadon.Size = new Size(874, 147);
            DGVhoadon.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(253, 257);
            label8.Name = "label8";
            label8.Size = new Size(277, 28);
            label8.TabIndex = 13;
            label8.Text = "DANH SÁCH CÁC HÓA ĐƠN";
            label8.Click += label8_Click;
            // 
            // txtngaysinh
            // 
            txtngaysinh.Location = new Point(109, 146);
            txtngaysinh.Name = "txtngaysinh";
            txtngaysinh.Size = new Size(205, 27);
            txtngaysinh.TabIndex = 12;
            // 
            // txtchucvu
            // 
            txtchucvu.Location = new Point(109, 212);
            txtchucvu.Name = "txtchucvu";
            txtchucvu.Size = new Size(205, 27);
            txtchucvu.TabIndex = 11;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(109, 85);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(205, 27);
            txtTen.TabIndex = 10;
            // 
            // txthsl
            // 
            txthsl.Location = new Point(549, 139);
            txthsl.Name = "txthsl";
            txthsl.Size = new Size(205, 27);
            txthsl.TabIndex = 9;
            // 
            // txtmaphong
            // 
            txtmaphong.Location = new Point(549, 202);
            txtmaphong.Name = "txtmaphong";
            txtmaphong.Size = new Size(205, 27);
            txtmaphong.TabIndex = 8;
            // 
            // txtphai
            // 
            txtphai.Location = new Point(549, 81);
            txtphai.Name = "txtphai";
            txtphai.Size = new Size(205, 27);
            txtphai.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(450, 202);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 6;
            label7.Text = "Mã phòng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(450, 146);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 5;
            label6.Text = "Hệ số lương";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(475, 84);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 4;
            label5.Text = "Phái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 209);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "HS chức vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 146);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 88);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(176, 24);
            label1.Name = "label1";
            label1.Size = new Size(338, 38);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // frmTimhoadon_Nhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 556);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmTimhoadon_Nhanvien";
            Text = "TÌM KIẾM HÓA ĐƠN";
            Load += frmTimhoadon_Nhanvien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVhoadon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtngaysinh;
        private TextBox txtchucvu;
        private TextBox txtTen;
        private TextBox txthsl;
        private TextBox txtmaphong;
        private TextBox txtphai;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbSelect;
        private Label label9;
        private Button button2;
        private Button button1;
        private DataGridView DGVhoadon;
        private Label label8;
    }
}