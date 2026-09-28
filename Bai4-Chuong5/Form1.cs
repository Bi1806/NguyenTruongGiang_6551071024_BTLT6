namespace Bai4_Chuong5
{
    public partial class FormDanhBa : Form
    {
        private int _indexDangSua = -1;
        public FormDanhBa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập số điện thoại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSDT.Focus();
                return;
            }

            string lienHe = txtTen.Text.Trim() + " - " + txtSDT.Text.Trim();

            if (_indexDangSua == -1)
            {
                // Thêm mới
                lstLienHe.Items.Add(lienHe);

                MessageBox.Show(
                    "Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                // Cập nhật liên hệ đang sửa
                lstLienHe.Items[_indexDangSua] = lienHe;

                MessageBox.Show(
                    "Cập nhật thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                _indexDangSua = -1;
            }

            txtTen.Clear();
            txtSDT.Clear();
            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để xóa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string lienHe = lstLienHe.SelectedItem.ToString();

            string ten = lienHe.Split('-')[0].Trim();

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa liên hệ " + ten +
                "? Thao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(lstLienHe.SelectedIndex);

                MessageBox.Show(
                    "Xóa thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để sửa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            _indexDangSua = lstLienHe.SelectedIndex;

            string lienHe = lstLienHe.SelectedItem.ToString();

            string[] parts = lienHe.Split('-');

            txtTen.Text = parts[0].Trim();
            txtSDT.Text = parts[1].Trim();

            txtTen.Focus();
        }

        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) ||
      !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                DialogResult ketQua = MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (ketQua == DialogResult.Yes)
                {
                    // Cho phép thoát
                    e.Cancel = false;
                }
                else if (ketQua == DialogResult.No)
                {
                    // Xóa dữ liệu rồi thoát
                    txtTen.Clear();
                    txtSDT.Clear();

                    e.Cancel = false;
                }
                else
                {
                    // Cancel → không cho đóng Form
                    e.Cancel = true;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
