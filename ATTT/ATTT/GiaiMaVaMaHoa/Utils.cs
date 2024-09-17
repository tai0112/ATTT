using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTT.Utils
{
    public class Utils
    {
        public char[] bangChuCai = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public int GetIndex(char ch)
        {
            int i = 0;
            i = Array.FindIndex(bangChuCai, e => e.Equals(ch));
            return i;
        }
    }
}
