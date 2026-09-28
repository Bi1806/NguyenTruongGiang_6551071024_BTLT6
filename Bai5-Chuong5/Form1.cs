namespace Bai5_Chuong5
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();

            cboPhim.Items.Add("Avengers: Endgame");
            cboPhim.Items.Add("Doraemon");
            cboPhim.Items.Add("Conan");
            cboPhim.Items.Add("Lật Mặt");

            cboSuatChieu.Items.Add("09:00");
            cboSuatChieu.Items.Add("13:00");
            cboSuatChieu.Items.Add("17:00");
            cboSuatChieu.Items.Add("20:00");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên khách!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTenKhach.Focus();
                return;
            }

            if (cboPhim.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn phim!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cboPhim.Focus();
                return;
            }

            if (cboSuatChieu.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn suất chiếu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cboSuatChieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn ghế!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            MessageBox.Show(
                "Xác nhận đặt vé?\n\n" +
                "Tên khách: " + txtTenKhach.Text.Trim() + "\n" +
                "Phim: " + cboPhim.Text + "\n" +
                "Suất chiếu: " + cboSuatChieu.Text + "\n" +
                "Ghế: " + txtGheDaChon.Text + "\n" +
                "Giá vé: 75.000đ",
                "Xác nhận đặt vé",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            cboPhim.SelectedIndex = -1;
            cboSuatChieu.SelectedIndex = -1;
            txtGheDaChon.Clear();

            txtTenKhach.Focus();
        }
    }
}
