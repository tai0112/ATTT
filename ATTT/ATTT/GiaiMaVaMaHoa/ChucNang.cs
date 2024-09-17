using GiaiMaVaMaHoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTT.GiaiMaVaMaHoa
{
    public class ChucNang
    {
        private GiaiMaThongTin _giaiMaThongTin = null;
        private MaHoaThongTin _maHoaThongTin = null;
        public GiaiMaThongTin GiaiMaThongTin
        {
            get
            {
                if(_giaiMaThongTin == null)
                {
                    _giaiMaThongTin = new GiaiMaThongTin();
                }
                return _giaiMaThongTin;
            }
        }

        public MaHoaThongTin MaHoaThongTin 
        {
            get
            {
                if(_maHoaThongTin == null)
                {
                    _maHoaThongTin = new MaHoaThongTin();
                }
                return _maHoaThongTin;
            }
        }
    }
}
