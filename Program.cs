using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceOOP2
{
    class Program
    {
        static void Main()
        {
            Cash cash = Edit();
            Memo(cash);
            Console.ReadKey();
        }

        static Cash Edit()
        {
            try
            {
                Console.Write("Номинал купюры: ");
                int banknote = int.Parse(Console.ReadLine());
                Console.Write("Количество купюр: ");
                int amount = int.Parse(Console.ReadLine());
                Cash cash = new Cash();
                cash = new Cash(banknote, amount);
                return cash;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return Edit();
            }
        }
        static void Memo(Cash cash)
        {
            Console.WriteLine($"Сумма: {cash.GetInfo()}");
        }
    }
}
