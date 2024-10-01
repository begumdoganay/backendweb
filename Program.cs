using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        // Girdiğimiz değerin 10'dan büyük mü küçük mü olduğunu kontrol edelim
        if (sayi == 10)
        {
            Console.WriteLine("Girilen sayı 10'a eşit.");
        }
        else if (sayi < 10)
        {
            Console.WriteLine("Girilen sayı 10'dan küçüktür.");
        }
        else
        {
            Console.WriteLine("Girilen sayı 10'dan büyüktür.");
        }

        // Girdiğimiz sayının tek mi çift mi olduğunu kontrol edelim
        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girilen sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Girilen sayı tektir.");
        }
    }
}
