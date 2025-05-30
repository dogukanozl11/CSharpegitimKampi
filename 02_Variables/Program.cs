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

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı : ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı : ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi : ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("İl bilgisi : ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yaş : ");
            //passengerAge = Console.ReadLine();
            //Console.Write("TC Kimlik Numarası : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("*-----------------------------------------------*");
            //Console.WriteLine("Yolcu TC kimlik No  : " + passengerIdentityNumber + " - Yolcu Ad Soyad : " + passengerName+ " " + passengerSurname + " " + passengerDistrict + " / "+ passengerCity + " " +passengerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz : ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken : " + totalPrice + " TL ");
            #endregion

            #region Klavyeden Ondalık Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write( "Lütfen 1.Sınav notunu giriniz : " );
            //exam1 = double.Parse( Console.ReadLine() );


            //Console.Write("Lütfen 2.Sınav notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());


            //Console.Write("Lütfen 3.Sınav notunu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1+exam2+exam3) / 3;

            //Console.WriteLine();

            //Console.WriteLine("Sınav Ortalamanız : " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz : ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender );

            #endregion

            Console.Read();
        }
    }
}
