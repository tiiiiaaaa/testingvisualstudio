using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1_t6
{
    class Program
    {
        static void Main(string[] args)
        {
            double gas;
            double money;

            Console.WriteLine("Anna matka kilometreina: ");
            string line = Console.ReadLine();
            int km = int.Parse(line);

            gas = (7.02 / 100) * km;
            money = 1.595 * gas;

            Console.WriteLine("Bensaa kului : " + gas + " litraa");
            Console.WriteLine("Kulutus: " + money + " euroa");
        
            
        }
    }
}
