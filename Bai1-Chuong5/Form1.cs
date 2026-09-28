using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bai1_Chuong5
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();

            // Nút Hủy không thực hiện validation
            btnHuy.CausesValidation = false;
        }

        // Hàm kiểm tra dữ liệu
        private bool KiemTraHopLe()
        {
            bool hopLe = true;

            // 1. Kiểm tra họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(
                    txtHoTen,
                    "Họ tên không được để trống!"
                );

                hopLe = false;
            }
            else if (txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(
                    txtHoTen,
                    "Họ tên phải có ít nhất 3 ký tự!"
                );

                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }


            // 2. Kiểm tra số điện thoại
            string sdt = txtSDT.Text.Trim();

            if (!Regex.IsMatch(sdt, @"^0[0-9]{9}$"))
            {
                errorProvider1.SetError(
                    txtSDT,
                    "Số điện thoại phải gồm đúng 10 chữ số và bắt đầu bằng 0!"
                );

                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }


            // 3. Kiểm tra Gmail
            string email = txtEmail.Text.Trim();

            string mauGmail = @"^[a-zA-Z0-9](?!.*\.\.)[a-zA-Z0-9._%+-]*[a-zA-Z0-9]@gmail\.com$";

            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Email không được để trống!"
                );

                hopLe = false;
            }
            else if (!Regex.IsMatch(email, mauGmail))
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Email Gmail không đúng định dạng! Ví dụ: nguyenvana@gmail.com"
                );

                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // 4. Kiểm tra mật khẩu
            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(
                    txtMatKhau,
                    "Mật khẩu phải có ít nhất 6 ký tự!"
                );

                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }


            // 5. Kiểm tra xác nhận mật khẩu
            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(
                    txtXacNhanMK,
                    "Mật khẩu xác nhận không khớp!"
                );

                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }


        // Nút Đăng ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show(
                "Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // Nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            Close();
        }
    }
}