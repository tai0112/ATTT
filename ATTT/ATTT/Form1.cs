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
            groupBox1.Text = "Bản rõ";
            groupBox2.Text = "Bản mã";
            string duLieuCanMaHoa = txtDuLieuMaHoa.Text.Trim(), ketQua = "";
            int khoa = 0;
            if(duLieuCanMaHoa.Length > 0)
            {
                if (int.TryParse(txtKhoa.Text.Trim(), out khoa))
                {
                    ketQua = cn.MaHoaThongTin.MaHoaCeasarCipher(duLieuCanMaHoa, khoa);
                    txtKetQua.Text = ketQua;
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }else
            {
                MessageBox.Show("Lỗi");
                txtDuLieuMaHoa.Focus();
                return;
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDuLieuMaHoa.Clear();
            txtKetQua.Clear();
            txtDuongDan.Clear();
            txtKhoa.Clear();
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Bản mã";
            groupBox2.Text = "Bản rõ";
            string duLieuCanMaHoa = txtDuLieuMaHoa.Text.Trim(), ketQua = "";
            if(duLieuCanMaHoa.Length > 0)
            {
                int khoa = 0;
                if (int.TryParse(txtKhoa.Text.Trim(), out khoa))
                {
                    ketQua = cn.GiaiMaThongTin.GiaiMaThongTinCeaserCipher(duLieuCanMaHoa, khoa);
                    txtKetQua.Text = ketQua;
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }else
            {
                MessageBox.Show("Lỗi");
                txtDuLieuMaHoa.Focus();
                return;
            }
            
        }


        private void btnChonFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = openFileDialog1.FileName;
                txtDuongDan.ReadOnly = true;
            }
        }

        private void txtDuongDan_TextChanged(object sender, EventArgs e)
        {
            //Khai báo biến
            string duongDan = "", noiDung = "";

            duongDan = txtDuongDan.Text.Trim();

            //Gọi hàm lấy dữ liệu từ file
            noiDung = FileHelpers.DocNoiDungFile(duongDan);

            //Hiển thị
            txtDuLieuMaHoa.Text = noiDung;
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
    }
}
