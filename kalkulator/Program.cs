using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrograman_22_11_4828
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kalkulator";

            Console.WriteLine("Pilih Menu Kalkulator");
            Console.WriteLine("\n\n1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");

            Console.WriteLine("Input Nomor Menu [1...4]: ");
            int angka = int.Parse(Console.ReadLine());

            int a,b ;
            switch (angka)
            {

                case 1:
                    Console.Write("\nInputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nInputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + penambahan(a, b));
                    break;

                case 2:
                    Console.Write("\nInputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nInputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                    break;

                case 3:

                    Console.Write("\nInputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nInputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                    break;

                case 4:
                    Console.Write("\nInputkan nilai a = ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nInputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
                    break;

                default:
                    Console.WriteLine("Maaf menu yang anda pilih tidak tersedia ");
                    break;

            }

           
            Console.ReadKey();
        }

        static int penambahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }



    }
}