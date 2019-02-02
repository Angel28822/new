turtle git
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bileti
{
    class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string kategoriq = Console.ReadLine();
            int horata = int.Parse(Console.ReadLine());
            double procent;
            double pari;
            if (horata <= 4)
                procent = 0.75;
            else if (horata <= 9)
                procent = 0.6;
            else if (horata <= 24)
                procent = 0.5;
            else if (horata <= 49)
                procent = 0.4;
            else
                procent = 0.25;
            pari = budjet - procent * budjet;
            if (kategoriq=="Normal"&&pari>249.99*horata)
                Console.WriteLine("Yes! You have {0:F2} leva left.",pari-249.99*horata);
            else if (kategoriq =="VIP"&&pari>499.99*horata)
                Console.WriteLine("Yes! You have {0:F2} leva left.", pari - 499.99*horata);
            else if (kategoriq == "VIP" && pari < 499.99 * horata)
                Console.WriteLine("Not enough money! You need {0:F2} leva", 499.99 * horata- pari);
            else if (kategoriq == "Normal" && pari < 249.99 * horata)
                Console.WriteLine("Not enough money! You need {0:F2} leav", 249.99 * horata - pari);
        }
    }
}
