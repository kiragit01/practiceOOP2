using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceOOP2
{
    public static class Consts
    {
        public static List<int> banknotes = new List<int> {1, 5, 10, 25, 50, 100, 200, 500 };

        public static bool IsBanknote(int n)
        {
            return banknotes.Contains(n);
        }
    }
}
