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
    public partial class frmNhanVien : Form
    {
        public string msnv { get; set; }
        public string tennv { get; set; }
        public string luong { get; set; }
        public frmNhanVien()
        {
            InitializeComponent();

        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }

  
        private void btnDongY_Click(object sender, EventArgs e)
        {
            msnv = txt_msnv.Text;
            tennv = txt_ten.Text;
            luong = txt_luong.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

      
    }
}
