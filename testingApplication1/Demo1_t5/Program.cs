using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_t5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kysytään 3 kokonaislukua. Tulostetaan niistä suurin.

            int luku1, luku2, luku3;

            Console.WriteLine("Anna kolme lukua: ");
            luku1 = Convert.ToInt32(Console.ReadLine());
            luku2 = Convert.ToInt32(Console.ReadLine());
            luku3 = Convert.ToInt32(Console.ReadLine());
            if (luku1 > luku2)
            {
                if (luku1 > luku3)
                {
                    Console.WriteLine("Suurin luku on " + luku1);
                }
                else
                {
                    Console.WriteLine("Suurin luku on " + luku3);
                }
            else if (luku2 < luku3) 
                {
                    Console.WriteLine("The Greatest Of Three numbers are:" + luku2);
                }
                else
                {
                    Console.WriteLine("The Greatest Of Three numbers are:" + luku3);
                }
            }

        Console.ReadLine();
        }
    }
}
