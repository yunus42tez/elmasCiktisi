using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elmasCiktisi
{
    internal class Elmas
    {
        private static void Main(string[] args)
        {
        start:
            Console.WriteLine("bir sayı giriniz, girdiğiniz sayı elmas görüntüsünün büyüklüğünü belirleyecek :");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                for (int y = 1; y <= x - i; y++)
                {
                    Console.Write(" ");
                }
                for (int y = 1; y <= 2 * i - 1; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = x - 1; i >= 1; i--)
            {
                for (int y = 1; y <= x - i; y++)
                {
                    Console.Write(" ");
                }
                for (int y = 1; y <= 2 * i - 1; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Write("\n\n\n");

            Console.WriteLine("Başa dönmek için enter'a basınız");
            Console.ReadLine();
            goto start;
        }
    }
}