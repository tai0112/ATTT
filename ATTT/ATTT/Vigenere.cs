using ATTT.GiaiMaVaMaHoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATTT
{
    public partial class Vigenere : Form
    {
        ChucNang cn = new ChucNang();
        public Vigenere()
        {
            InitializeComponent();
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {

        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string banRo = txtDuLieuMaHoa.Text.Trim(), khoa = txtKhoa.Text.Trim();
            if(banRo.Length == 0 || khoa.Length == 0)
            {
                MessageBox.Show("Lỗi");
                return;
            }
            MessageBox.Show(cn.MaHoaThongTin.MaHoaVigenere(banRo, khoa));
            txtKetQua.Text = cn.MaHoaThongTin.MaHoaVigenere(banRo, khoa);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string noiDung = "";

            noiDung = txtKetQua.Text;

            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                //Gọi hàm ghi ra file
                FileHelpers.GhiNoiDungRaFile(noiDung, saveFileDialog1.FileName);

                MessageBox.Show("Ghi dữ liệu ra file thành công", "Thông báo");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = openFileDialog1.FileName;
                txtDuongDan.ReadOnly = true;
            }
        }
    }
}
