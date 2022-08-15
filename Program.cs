using System;
namespace whileforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //1 den başlayarak consola gitilen sayıya kadar(sayı dahil) ortalama hesaplayıp consola yazıralım
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while(sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);


            //'a' dan başlayarak 'z' ye kadar tüm harfleri console a yazdır
            char character='a';
            while(character<'z')
            {
                Console.Write(character);
                character ++;
            }

            Console.WriteLine("*****Foreach***");
            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
            
        }

    }
}
