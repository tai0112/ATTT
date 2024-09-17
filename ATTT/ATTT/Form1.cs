using ATTT.GiaiMaVaMaHoa;
using GiaiMaVaMaHoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATTT
{
    public partial class frmChinh : Form
    {
        ChucNang cn = new ChucNang();
        public frmChinh()
        {
            InitializeComponent();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string duLieuCanMaHoa = txtDuLieuMaHoa.Text.Trim(), ketQua = "";
            int khoa = 0;
            if (int.TryParse(txtKhoa.Text.Trim(), out khoa))
            {
                ketQua = cn.MaHoaThongTin.MaHoaCeasarCipher(duLieuCanMaHoa, khoa);
                txtKetQua.Text = ketQua;
            }
            else
            {
                MessageBox.Show("Lỗi"); 
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDuLieuMaHoa.Clear();
            txtKetQua.Clear();
            txtKhoa.Clear();
        }
    }
}
