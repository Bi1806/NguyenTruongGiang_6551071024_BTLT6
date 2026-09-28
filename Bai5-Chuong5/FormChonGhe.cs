using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai5_Chuong5
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; }

        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();

            // Thêm danh sách ghế
            for (char hang = 'A'; hang <= 'C'; hang++)
            {
                for (int so = 1; so <= 5; so++)
                {
                    lstGhe.Items.Add(hang + so.ToString());
                }
            }

            if (!string.IsNullOrWhiteSpace(gheHienTai))
            {
                lstGhe.SelectedItem = gheHienTai;
                lblGheDaChon.Text = "Đang chọn: " + gheHienTai;
            }
        }


        private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
            {
                lblGheDaChon.Text =
                    "Đang chọn: " + lstGhe.SelectedItem.ToString();
            }
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn một ghế!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            GheChon = lstGhe.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}