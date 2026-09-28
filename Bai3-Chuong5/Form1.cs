namespace Bai3_Chuong5
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();


            DangKyEnterChuyenField();
        }
        private void DangKyEnterChuyenField()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.KeyPress += TextBox_KeyPress;
                }
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    SelectNextControl(
                        (Control)sender,
                        true,
                        true,
                        true,
                        true
                    );
                }
            }
        }

        private void txtToan_Enter(object sender, EventArgs e)
        {
            txtToan.SelectAll();
        }

        private void txtVan_Enter(object sender, EventArgs e)
        {
            txtVan.SelectAll();
        }

        private void txtAnh_Enter(object sender, EventArgs e)
        {
            txtAnh.SelectAll();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            decimal diemToan;

            if (!decimal.TryParse(txtToan.Text.Trim(), out diemToan) ||
                diemToan < 0 ||
                diemToan > 10)
            {
                errorProvider1.SetError(
                    txtToan,
                    "Điểm Toán phải là số từ 0 đến 10!"
                );

                txtToan.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtToan, "");
            }
            decimal diemVan;

            if (!decimal.TryParse(txtVan.Text.Trim(), out diemVan) ||
                diemVan < 0 ||
                diemVan > 10)
            {
                errorProvider1.SetError(
                    txtVan,
                    "Điểm Văn phải là số từ 0 đến 10!"
                );

                txtVan.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtVan, "");
            }
            decimal diemAnh;

            if (!decimal.TryParse(txtAnh.Text.Trim(), out diemAnh) ||
                diemAnh < 0 ||
                diemAnh > 10)
            {
                errorProvider1.SetError(
                    txtAnh,
                    "Điểm Anh phải là số từ 0 đến 10!"
                );

                txtAnh.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtAnh, "");
            }
            lstDanhSach.Items.Add(
    txtMaHS.Text + " | " +
    txtHoTen.Text + " | T:" + diemToan +
    " V:" + diemVan +
    " A:" + diemAnh
);
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            txtMaHS.Focus();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            errorProvider1.SetError(txtToan, "");
            errorProvider1.SetError(txtVan, "");
            errorProvider1.SetError(txtAnh, "");

            txtMaHS.Focus();
        }
    }
}
