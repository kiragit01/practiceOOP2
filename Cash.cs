using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceOOP2
{
    class Cash
    {
        public int Banknote { get; set; }
        public int Amount { get; set;}

        public Cash(int banknote, int amount)
        {
            if (Consts.IsBanknote(banknote))
                Banknote = banknote;
            else throw new ArgumentException("Неверно введены данные номинала, введите заново.");
            Amount = amount;
        }

        public Cash() { }

        public string GetInfo()
        {
            return $"{Banknote * Amount}";
        }

    }
}
