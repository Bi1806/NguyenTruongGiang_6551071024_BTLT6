using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bai2_Chuong5
{
    public partial class FormDatPhong : Form
    {
        public FormDatPhong()
        {
            InitializeComponent();
        }

        private void txtHoTen_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtHoTen,
                    "Họ tên không được để trống!"
                );

                txtHoTen.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(txtHoTen, "");

                txtHoTen.BackColor = Color.Honeydew;
            }
        }

        private void txtHoTen_Validated(object sender, EventArgs e)
        {
            txtHoTen.BackColor = Color.Honeydew;
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();

            if (cccd.Length != 12 || !long.TryParse(cccd, out _))
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtCCCD,
                    "CCCD phải gồm đúng 12 chữ số!"
                );

                txtCCCD.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(txtCCCD, "");

                txtCCCD.BackColor = Color.Honeydew;
            }
        }

        private void txtCCCD_Validated(object sender, EventArgs e)
        {
            txtCCCD.BackColor = Color.Honeydew;
        }

        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;

            if (!DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                null,
                System.Globalization.DateTimeStyles.None,
                out ngayNhan))
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtNgayNhan,
                    "Ngày phải có dạng dd/MM/yyyy!"
                );

                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else if (ngayNhan.Date < DateTime.Today)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtNgayNhan,
                    "Ngày nhận phải từ hôm nay trở đi!"
                );

                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(txtNgayNhan, "");

                txtNgayNhan.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayNhan_Validated(object sender, EventArgs e)
        {
            txtNgayNhan.BackColor = Color.Honeydew;
        }

        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayTra;
            DateTime ngayNhan;

            // Kiểm tra ngày trả có đúng định dạng không
            if (!DateTime.TryParseExact(
                txtNgayTra.Text.Trim(),
                "dd/MM/yyyy",
                null,
                System.Globalization.DateTimeStyles.None,
                out ngayTra))
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày trả phải có dạng dd/MM/yyyy!"
                );

                txtNgayTra.BackColor = Color.MistyRose;

                return;
            }

            // Kiểm tra ngày nhận có hợp lệ không
            if (!DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                null,
                System.Globalization.DateTimeStyles.None,
                out ngayNhan))
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày nhận chưa hợp lệ!"
                );

                txtNgayTra.BackColor = Color.MistyRose;

                return;
            }

            // Ngày trả phải lớn hơn ngày nhận
            if (ngayTra <= ngayNhan)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày trả phải sau ngày nhận!"
                );

                txtNgayTra.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(txtNgayTra, "");

                txtNgayTra.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayTra_Validated(object sender, EventArgs e)
        {
            txtNgayTra.BackColor = Color.Honeydew;
        }

        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            int soNguoiLon;

            if (!int.TryParse(
                txtSoNguoiLon.Text.Trim(),
                out soNguoiLon) ||
                soNguoiLon < 1 ||
                soNguoiLon > 4)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtSoNguoiLon,
                    "Số người lớn phải là số nguyên từ 1 đến 4!"
                );

                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(txtSoNguoiLon, "");

                txtSoNguoiLon.BackColor = Color.Honeydew;
            }
        }

        private void txtSoNguoiLon_Validated(object sender, EventArgs e)
        {
            txtSoNguoiLon.BackColor = Color.Honeydew;
        }

        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            int soTreEm;

            if (!int.TryParse(
                txtSoTreEm.Text.Trim(),
                out soTreEm) ||
                soTreEm < 0 ||
                soTreEm > 3)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtSoTreEm,
                    "Số trẻ em phải là số nguyên từ 0 đến 3!"
                );

                txtSoTreEm.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(txtSoTreEm, "");

                txtSoTreEm.BackColor = Color.Honeydew;
            }
        }

        private void txtSoTreEm_Validated(object sender, EventArgs e)
        {
            txtSoTreEm.BackColor = Color.Honeydew;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            DateTime ngayNhan;
            DateTime ngayTra;

            DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                null,
                System.Globalization.DateTimeStyles.None,
                out ngayNhan);

            DateTime.TryParseExact(
                txtNgayTra.Text.Trim(),
                "dd/MM/yyyy",
                null,
                System.Globalization.DateTimeStyles.None,
                out ngayTra);

            int soDem = (ngayTra - ngayNhan).Days;

            int soNguoiLon = int.Parse(txtSoNguoiLon.Text);
            int soTreEm = int.Parse(txtSoTreEm.Text);

            MessageBox.Show(
                "Đặt phòng thành công!\n\n" +
                "Tên khách: " + txtHoTen.Text + "\n" +
                "Số đêm: " + soDem + "\n" +
                "Số người lớn: " + soNguoiLon + "\n" +
                "Số trẻ em: " + soTreEm,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
