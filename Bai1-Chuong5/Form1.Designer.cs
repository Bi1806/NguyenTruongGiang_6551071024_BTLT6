namespace Bai1_Chuong5
{
    partial class FormDangKy
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
            components = new System.ComponentModel.Container();
            txtHoTen = new TextBox();
            txtMatKhau = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtXacNhanMK = new TextBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(361, 90);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(148, 27);
            txtHoTen.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(361, 254);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(148, 27);
            txtMatKhau.TabIndex = 1;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(361, 151);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(148, 27);
            txtSDT.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(361, 198);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(148, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(361, 301);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(148, 27);
            txtXacNhanMK.TabIndex = 4;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(236, 369);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(392, 369);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 93);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 7;
            label1.Text = "Họ tên: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 151);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 8;
            label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 205);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 9;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 257);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 10;
            label4.Text = "Mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 301);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 11;
            label5.Text = "Xác nhận mật khẩu:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 9);
            label6.Name = "label6";
            label6.Size = new Size(282, 41);
            label6.TabIndex = 12;
            label6.Text = "Đăng ký tài khoản:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 58);
            label7.Name = "label7";
            label7.Size = new Size(214, 20);
            label7.TabIndex = 13;
            label7.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtMatKhau);
            Controls.Add(txtHoTen);
            Name = "FormDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtMatKhau;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtXacNhanMK;
        private Button btnDangKy;
        private Button btnHuy;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ErrorProvider errorProvider1;
        private Label label7;
        private Label label6;
    }
}
