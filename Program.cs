using System;

namespace Calculator
{
    class Program
    {
        static int tambah(int a, int b)
        {
            return a + b;
        }
        static int kurang(int a, int b)
        {
            return a - b;
        }

        static int bilanganPertama()
        {
            Console.Write("Masukan Bilangan Pertama : ");
            return int.Parse(Console.ReadLine());
        }
        static int bilanganKedua()
        {
            Console.Write("Masukan Bilangan Kedua : ");
            return int.Parse(Console.ReadLine());
        }

        static void menu()
        {
            Console.WriteLine("Pilih menu calculator\n");
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");
        }

        static char choose()
        {
            Console.Write("Masukan Pilihan [1..4] : ");
            return Convert.ToChar(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            menu();
            char pilihan = choose();
            Console.WriteLine();
            if (pilihan < '1' || pilihan > '4')
            {
                Console.Write("Maaf, menu yang anda masukan tidak tersedia");
            }

            if (pilihan == '1')
            {
                int bil1 = bilanganPertama();
                int bil2 = bilanganKedua();
                Console.WriteLine("Hasil Penambahan : {0} + {1} = {2}", bil1, bil2, tambah(bil1, bil2));
            }
            else if (pilihan == '2')
            {
                int bil1 = bilanganPertama();
                int bil2 = bilanganKedua();
                Console.WriteLine("Hasil Pengurangan : {0} - {1} = {2}", bil1, bil2, kurang(bil1, bil2));
            }
            Console.ReadKey();
        }
    }
}
