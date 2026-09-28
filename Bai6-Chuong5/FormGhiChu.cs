using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai6_Chuong5
{
    public partial class FormGhiChu : Form
    {
        public FormGhiChu()
        {
            InitializeComponent();
        }

        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnLuuGhiChu.PerformClick();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (txtNoiDung.Modified)
                {
                    DialogResult result = MessageBox.Show(
                        "Nội dung đã thay đổi. Bạn có muốn đóng ghi chú không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }

                e.SuppressKeyPress = true;
            }
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNoiDung.Text.Length >= 500 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblTieuDe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightBlue;
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = SystemColors.Control;
        }

        private void txtTieuDe_Validating(object sender, CancelEventArgs e)
        {
            string tieuDe = txtTieuDe.Text.Trim();

            if (string.IsNullOrWhiteSpace(tieuDe))
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề không được để trống"
                );

                txtTieuDe.BackColor = Color.MistyRose;
            }
            else if (tieuDe.Length > 50)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề tối đa 50 ký tự"
                );

                txtTieuDe.BackColor = Color.MistyRose;
            }
        }

        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            txtTieuDe.BackColor = Color.White;
            errorProvider1.SetError(txtTieuDe, "");
        }

        private void btnLuuGhiChu_Enter(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            this.Text = txtTieuDe.Text.Trim();

            MessageBox.Show(
                "Đã lưu ghi chú",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
