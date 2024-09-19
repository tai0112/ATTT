using ATTT.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiMaVaMaHoa
{
    public class GiaiMaThongTin
    {
        Utils u = new Utils();
        public string GiaiMaThongTinCeaserCipher(string banMa, int k)
        {
            StringBuilder banRo = new StringBuilder("");
            int i = 0, temp = 0, j = 0;
            banMa = banMa.ToLower();
            foreach(char c in banMa)
            {
                char l = ' ';
                if (c != ' ')
                {
                    i = u.GetIndex(c);
                    j = i - k;  
                    if (j < 0)
                    {
                        j += 26;
                    }
                    temp = j % 26;

                    banRo.Append(u.bangChuCai[temp]);
                }else
                {
                    banRo.Append(' ');
                }
            }
            return banRo.ToString().ToUpper();
        }
    }
}
