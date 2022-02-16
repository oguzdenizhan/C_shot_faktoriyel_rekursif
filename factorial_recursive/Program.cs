using System;

namespace factorial_recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, z;  // değişken oluştur
            Console.WriteLine("Bir sayı giriniz:"); // kullanıcıdan sayı iste
            sayi = Convert.ToInt32(Console.ReadLine()); //string'den integer a çevir ve sayi değişkenine ata 

            z = factorial(sayi); //factorial metodu çağır ve z ye ata
            Console.Write(sayi + " faktoriyel : " + z); // ekrana yaz

            int factorial(int x) // metot 
            {
                if (x == 0) // eğer x =0 ise    
                    return 1; // 1'e dön

                else // değilse
                    return x * factorial(x - 1); // x'i x-1 faktöriyel ile çarp

            }
            Console.Read(); //Bekle
        }
    }
}

