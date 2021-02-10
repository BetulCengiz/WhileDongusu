using System;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            //int i;
            //i = 1;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //klavyeden tek sayı girilene kadar sayı isteyen program

            //Console.WriteLine("Tek sayı giriniz");
            //int a;
            //a = Convert.ToInt32(Console.ReadLine());

            //while (a % 2 == 0)
            //{
            //    Console.WriteLine("Tek sayı giriniz");
            //    a = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine("Tek sayı girdiniz " + a);

            // Faktöriyel
            Console.WriteLine("Bir sayı giriniz");
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            int fak = 1;

            while (b>0)
            {
                fak = b * fak;                       
                b = b - 1;
                
            }
            Console.WriteLine("Faktöriyel: "+fak);

        }
            
    }
}
