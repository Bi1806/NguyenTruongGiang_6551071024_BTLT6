namespace Bai6_Chuong5
{
    partial class FormGhiChu
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
            components = new System.ComponentModel.Container();
            lblTieuDeForm = new Label();
            lblTieuDe = new Label();
            lblNoiDung = new Label();
            txtNoiDung = new TextBox();
            txtTieuDe = new TextBox();
            lbl = new Label();
            cboMucDoUuTien = new ComboBox();
            btnLuuGhiChu = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDeForm
            // 
            lblTieuDeForm.AutoSize = true;
            lblTieuDeForm.Location = new Point(31, 29);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Size = new Size(147, 20);
            lblTieuDeForm.TabIndex = 0;
            lblTieuDeForm.Text = "GHI CHÚ CÔNG VIỆC";
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(54, 71);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(61, 20);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "Tiêu đề:";
            lblTieuDe.MouseDoubleClick += lblTieuDe_MouseDoubleClick;
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Location = new Point(54, 122);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new Size(74, 20);
            lblNoiDung.TabIndex = 2;
            lblNoiDung.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(54, 163);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(300, 150);
            txtNoiDung.TabIndex = 3;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(140, 68);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(191, 27);
            txtTieuDe.TabIndex = 4;
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(54, 325);
            lbl.Name = "lbl";
            lbl.Size = new Size(113, 20);
            lbl.TabIndex = 5;
            lbl.Text = "Mức độ ưu tiên:";
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Items.AddRange(new object[] { "Thấp", "", "Trung bình", "", "Cao" });
            cboMucDoUuTien.Location = new Point(180, 322);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(151, 28);
            cboMucDoUuTien.TabIndex = 6;
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.Location = new Point(455, 322);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(94, 29);
            btnLuuGhiChu.TabIndex = 7;
            btnLuuGhiChu.Text = "Lưu";
            btnLuuGhiChu.UseVisualStyleBackColor = true;
            btnLuuGhiChu.Enter += btnLuuGhiChu_Enter;
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(lbl);
            Controls.Add(txtTieuDe);
            Controls.Add(txtNoiDung);
            Controls.Add(lblNoiDung);
            Controls.Add(lblTieuDe);
            Controls.Add(lblTieuDeForm);
            KeyPreview = true;
            Name = "FormGhiChu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ghi chú mới";
            KeyDown += FormGhiChu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDeForm;
        private Label lblTieuDe;
        private Label lblNoiDung;
        private TextBox txtNoiDung;
        private TextBox txtTieuDe;
        private Label lbl;
        private ComboBox cboMucDoUuTien;
        private Button btnLuuGhiChu;
        private ErrorProvider errorProvider1;
    }
}