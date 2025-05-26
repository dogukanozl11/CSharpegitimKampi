using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice,orangePrice,strawberryPrice,patatoPrice,tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.94;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("--- Elma Birim Fiayetı : " + applePrice + " TL ");
            //Console.WriteLine("--- Portakal Birim Fiayetı : " + orangePrice + " TL ");
            //Console.WriteLine("--- Çilek Birim Fiayetı : " + strawberryPrice + " TL ");
            //Console.WriteLine("--- Patates Birim Fiayetı : " + patatoPrice + " TL ");
            //Console.WriteLine("--- Domates Birim Fiayetı : " + tomatoPrice + " TL ");

            //double appleGram , orangeGram,strawberryGram ,patatoGram , tomatoGram ;

            //appleGram =1.245;
            //orangeGram = 2.654;
            //strawberryGram =2.500;
            //patatoGram =5.450;
            //tomatoGram =2.500;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double patatoTotalPrice = patatoGram * patatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Elmanın Toplam Fiyatı : " + appleTotalPrice);
            //Console.WriteLine("Portakal Toplam Fiyatı : " + orangeTotalPrice);
            //Console.WriteLine("Çilek Toplam Fiyatı : " + strawberryTotalPrice);      
            //Console.WriteLine("Patates Toplam Fiyatı : " + patatoTotalPrice);
            //Console.WriteLine("Domates Toplam Fiyatı : " + tomatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün : Elma - " + "Birim Fiyat : " + applePrice + " - Gramaj : " + appleGram + " - Toplam Tutar : " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün : Portakal - " + "Birim Fiyat : " + orangePrice + " - Gramaj : " + orangeGram + " - Toplam Tutar : " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün : Çilek - " + "Birim Fiyat : " + strawberryPrice + " - Gramaj : " + strawberryGram + " - Toplam Tutar : " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün : Patates - " + "Birim Fiyat : " + patatoPrice + " - Gramaj : " + patatoGram + " - Toplam Tutar : " + patatoTotalPrice);
            //Console.WriteLine("Alınan Ürün : Domates - " + "Birim Fiyat : " + tomatoPrice + " - Gramaj : " + tomatoGram + " - Toplam Tutar : " + tomatoTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar : " + shoppingTotalPrice + " TL ");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı : ");
            passengerName = Console.ReadLine();
            Console.Write("Yolcu Soyadı : ");
            passengerSurname = Console.ReadLine();
            Console.Write("İlçe Bilgisi : ");
            passengerDistrict = Console.ReadLine();
            Console.Write("İl bilgisi : ");
            passengerCity = Console.ReadLine();
            Console.Write("Yaş : ");
            passengerAge = Console.ReadLine();
            Console.Write("TC Kimlik Numarası : ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("*-----------------------------------------------*");
            Console.WriteLine("Yolcu : " + passengerName + " " + passengerSurname);

            #endregion
            Console.Read();
        }
    }
}
