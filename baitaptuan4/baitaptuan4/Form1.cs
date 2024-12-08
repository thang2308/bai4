using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaptuan4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (dgvListNhanVien.Columns.Count == 0)
            {
                dgvListNhanVien.Columns.Add("MSNV", "MSNV");
                dgvListNhanVien.Columns.Add("TenNhanVien", "Tên nhân viên");
                dgvListNhanVien.Columns.Add("Luong", "Lương");
            }
            dgvListNhanVien.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhanVien fnhanvien = new frmNhanVien();
            if (fnhanvien.ShowDialog() == DialogResult.OK)
            {
                dgvListNhanVien.Rows.Add(fnhanvien.msnv, fnhanvien.tennv, fnhanvien.luong);
                dgvListNhanVien.Refresh();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvListNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvListNhanVien.SelectedRows[0];
                try
                {
                    if (row.IsNewRow) return;

                    string msnv = row.Cells["MSNV"].Value?.ToString() ?? string.Empty;
                    string tenNV = row.Cells["TenNhanVien"].Value?.ToString() ?? string.Empty;
                    string luongCB = row.Cells["Luong"].Value?.ToString() ?? string.Empty;

                    frmNhanVien fnhanvien = new frmNhanVien
                    {
                        msnv = msnv,
                        tennv = tenNV,
                        luong = luongCB
                    };

                    if (fnhanvien.ShowDialog() == DialogResult.OK)
                    {
                        row.Cells["MSNV"].Value = fnhanvien.msnv;
                        row.Cells["TenNhanVien"].Value = fnhanvien.tennv;
                        row.Cells["Luong"].Value = fnhanvien.luong;
                    }

                    dgvListNhanVien.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi chỉnh sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvListNhanVien.ClearSelection();
                dgvListNhanVien.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvListNhanVien.SelectedRows.Count > 0)
            {

                    if (!dgvListNhanVien.SelectedRows[0].IsNewRow)
                    {
                        dgvListNhanVien.Rows.RemoveAt(dgvListNhanVien.SelectedRows[0].Index);
                    } 
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dgvListNhanVien.Refresh();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
