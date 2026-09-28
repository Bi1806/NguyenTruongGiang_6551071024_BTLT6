namespace Bai6_Chuong5
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tệpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mởGhiChúMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGhiChu frm = new FormGhiChu();

            frm.MdiParent = this;

            frm.FormClosed += FormGhiChu_FormClosed;

            frm.Show();

            CapNhatSoGhiChu();
        }

        private void CapNhatSoGhiChu()
        {
            lblTrangThai.Text =
                "Số ghi chú đang mở: " + this.MdiChildren.Length;
        }

        private async void FormGhiChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            await Task.Delay(1);
            CapNhatSoGhiChu();
        }

        private void xếpTầngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void xếpNgangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void xếpDọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sắpXếpCửaSổToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}