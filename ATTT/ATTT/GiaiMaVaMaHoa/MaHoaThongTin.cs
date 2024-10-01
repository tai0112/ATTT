using ATTT.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

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
                if(c != ' ')
                {
                    i = u.GetIndex(c);
                    temp = (i + k) % 26;
                    banMa.Append(u.bangChuCai[temp]);
                }else
                {
                    banMa.Append(' ');
                }

            }
            return banMa.ToString().ToUpper();
        }

        public string MaHoaPlayFair(string banRo, string khoa)
        {
            StringBuilder banMa = new StringBuilder("");
            string[,] bang = new string[5, 5];
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {

                }
            }
            return banMa.ToString();
        }

        public string MaHoaVigenere(string banRo, string khoa)
        {
            StringBuilder result = new StringBuilder();
            khoa = khoa.ToUpper();
            int keyIndex = 0;

            foreach (char c in banRo)
            {
                if (char.IsLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    char offset = isUpper ? 'A' : 'a';
                    char keyChar = khoa[keyIndex % khoa.Length];
                    int shift = keyChar - 'A';
                    char encryptedChar = (char)(((c - offset + shift) % 26) + offset);
                    result.Append(encryptedChar);
                    keyIndex++;
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }
}
