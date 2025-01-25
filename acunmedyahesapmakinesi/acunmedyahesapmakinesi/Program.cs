using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyahesapmakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***hesap makinesine hoşgeldiniz***");//hoşgeldiniz mesajı
            Console.WriteLine("--------------------"); //görsel açıdan etkili olması için çizgi ekledim
            double sayi1, sayi2,sonuc; //sayıları ve sonuc işlemini ekledim bunları double olarak ekledim çünkü bölme sonucu virgüllü çıkabilirdi

            Console.WriteLine("işlem yapılacak 1.sayıyı giriniz:"); //sayının girişini istedim
            sayi1 = int.Parse(Console.ReadLine());//sayı 1i aldım

            Console.WriteLine("işlem yapılacak 2.sayıyı giriniz:");//sayının girişini istedim
            sayi2 = int.Parse(Console.ReadLine());//sayi 2yi aldım

            Console.WriteLine("Lütfen yapacağınız işlemi seçiniz"); //işlemleri seçtirmek için bir liste hazırladım
            Console.WriteLine("1-toplama");
            Console.WriteLine("2-çıkartma");
            Console.WriteLine("3-çarpma");
            Console.WriteLine("4-bölme");
            
            Console.WriteLine(); //boşluk eklemek istedim

            int islem; //işlem seçtireceğim için işlemi tanımladım
            Console.WriteLine("lütfen hangi iilem çeşidini seçeceğinizi tuşlayınız"); //işlem seçenekleri arasından birisini seçtirdim
            islem = int.Parse(Console.ReadLine()); //burda seçimi aldırdım

            if (islem == 1) //sonuç yani girilen sayı 1 ise bu kısım çalışıyor
            {
                sonuc = sayi1 + sayi2; //toplama işlemini yaptırdım
                Console.WriteLine(sonuc); //sonucu ekrana yazdırdım
            }
            if (islem == 2)  //sonuç yani girilen sayı 2 ise bu kısım çalışıyor
            {
                
                sonuc = sayi1 - sayi2; //çıkartma işlemini yaptırdım
                Console.WriteLine(sonuc); //sonucu ekrana yazdırdım

            }
            if (islem == 3) //sonuç yani girilen sayı 3 ise bu kısım çalışıyor
            {
                    
                sonuc = sayi1 * sayi2; //çarpma işlemini yaptırdım
                Console.WriteLine(sonuc); //ekrana yazdırdım
            }
            if (islem == 4) //sonuç yani girilen sayı 4 ise bu kısım çalışıyor
            {
                
                sonuc = sayi1 / sayi2; //bölme işlemini yaptırdım
                Console.WriteLine(sonuc); //ekrana sonucu yazdırdım
            }
            else
            {
                Console.WriteLine("hatalı tuşlama yaptınız tekrar deneyiniz");
                 
                }
            Console.ReadLine();
        }
    }
}
