using ATTT.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiMaVaMaHoa
{
    public class MaHoaThongTin
    {
        Utils u = new Utils();
        public string MaHoaCeasarCipher(string banRo, int k)
        {
            StringBuilder banMa = new StringBuilder("");
            int i = 0, temp = 0;
            banRo = banRo.ToLower();
            foreach(char c in banRo)
            {
                i = u.GetIndex(c);
                temp = (i + k) % 26;
                banMa.Append(u.bangChuCai[temp]);
            }
            return banMa.ToString().ToUpper();
        }
    }
}
