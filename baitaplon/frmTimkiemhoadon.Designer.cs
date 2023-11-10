namespace baitaplon
{
    partial class Form2
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
            button2 = new Button();
            button1 = new Button();
            cbselect = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            txttong = new TextBox();
            label7 = new Label();
            DVGHH = new DataGridView();
            txtngayhd = new TextBox();
            txtdiachi = new TextBox();
            txtdienthoai = new TextBox();
            txtten = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DVGHH).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cbselect);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 282);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(65, 195);
            button2.Name = "button2";
            button2.Size = new Size(135, 52);
            button2.TabIndex = 3;
            button2.Text = "THOÁT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(65, 121);
            button1.Name = "button1";
            button1.Size = new Size(135, 52);
            button1.TabIndex = 2;
            button1.Text = "TÌM KIẾM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbselect
            // 
            cbselect.FormattingEnabled = true;
            cbselect.Location = new Point(65, 71);
            cbselect.Name = "cbselect";
            cbselect.Size = new Size(151, 28);
            cbselect.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 30);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 0;
            label1.Text = "Chọn/nhập số hóa đơn";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Violet;
            panel2.Controls.Add(txttong);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(DVGHH);
            panel2.Controls.Add(txtngayhd);
            panel2.Controls.Add(txtdiachi);
            panel2.Controls.Add(txtdienthoai);
            panel2.Controls.Add(txtten);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(378, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(833, 561);
            panel2.TabIndex = 1;
            // 
            // txttong
            // 
            txttong.Location = new Point(430, 486);
            txttong.Name = "txttong";
            txttong.Size = new Size(246, 27);
            txttong.TabIndex = 11;
            txttong.TextChanged += txttong_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(22, 486);
            label7.Name = "label7";
            label7.Size = new Size(368, 38);
            label7.TabIndex = 10;
            label7.Text = "TỔNG GIÁ TRỊ ĐƠN HÀNG";
            // 
            // DVGHH
            // 
            DVGHH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVGHH.Location = new Point(22, 227);
            DVGHH.Name = "DVGHH";
            DVGHH.RowHeadersWidth = 51;
            DVGHH.RowTemplate.Height = 29;
            DVGHH.Size = new Size(808, 238);
            DVGHH.TabIndex = 9;
            // 
            // txtngayhd
            // 
            txtngayhd.Location = new Point(518, 172);
            txtngayhd.Name = "txtngayhd";
            txtngayhd.Size = new Size(225, 27);
            txtngayhd.TabIndex = 8;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(518, 79);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(225, 27);
            txtdiachi.TabIndex = 7;
            // 
            // txtdienthoai
            // 
            txtdienthoai.Location = new Point(187, 165);
            txtdienthoai.Name = "txtdienthoai";
            txtdienthoai.Size = new Size(220, 27);
            txtdienthoai.TabIndex = 6;
            // 
            // txtten
            // 
            txtten.Location = new Point(187, 79);
            txtten.Name = "txtten";
            txtten.Size = new Size(220, 27);
            txtten.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(430, 172);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 4;
            label6.Text = "Ngày HĐ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(430, 82);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 3;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(85, 165);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 2;
            label4.Text = "Điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 79);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 1;
            label3.Text = "Khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(304, 21);
            label2.Name = "label2";
            label2.Size = new Size(253, 31);
            label2.TabIndex = 0;
            label2.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 575);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "TÌM KIẾM HÓA ĐƠN";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DVGHH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private ComboBox cbselect;
        private Label label1;
        private Panel panel2;
        private TextBox txtngayhd;
        private TextBox txtdiachi;
        private TextBox txtdienthoai;
        private TextBox txtten;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txttong;
        private Label label7;
        private DataGridView DVGHH;
    }
}