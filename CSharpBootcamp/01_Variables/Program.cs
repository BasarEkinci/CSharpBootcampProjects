using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Price List *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Apple Unity Price: " + applePrice + " TL");
            //Console.WriteLine("---- Orange Unit Price:" + orangePrice + " TL");
            //Console.WriteLine("---- Strawberry Unit Price: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Potato Unit Price:" + potatoPrice + " TL");
            //Console.WriteLine("---- Tomato Unit Price:" + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Purchased Product: Apple - " + "Unit Price: " + applePrice + " - Grammage: " + appleGram + " - Total Cost: " + appleTotalPrice);

            //Console.WriteLine("purchased product: Orange - " + "Unit Price: " + orangePrice + " - Grammage: " + orangeGram + " - Total Cost: " + orangeTotalPrice);

            //Console.WriteLine("purchased product: Çilek - " + "Unit Price: " + strawberryPrice + " - Grammage: " + strawberryGram + " - Total Cost: " + strawberryTotalPrice);

            //Console.WriteLine("purchased product: Potato - " + "Unit Price: " + potatoPrice + " - Grammage: " + potatoGram + " - Total Cost: " + potatoTotalPrice);

            //Console.WriteLine("purchased product: Tomato - " + "Unit Price: " + tomatoPrice + " - Grammage: " + tomatoGram + " - Total Cost: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Total Amount of Purchase:" + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //MEETING AT 20:00
            //"  ' 

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Airlines Passenger Information ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Passenger Name: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Passenger Surname Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("District Information: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("City Information: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Passenger Age: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Passenger ID: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Passenger ID: " + passengerIdentityNumber +  " - Passenger Name/Surname: " + passengerName + " " + passengerSurname + " "  + passengerDistrict  + " / " + passengerCity + " " + passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Please enter the number of shoes you purchased: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number of computer you purchased: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number of chairs you purchased: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number of TV you purchased: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Total Amount You Need to Pay: " +  totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Please enter your 1st exam grade: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter your 2nd exam grade: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter your 3rd exam grade: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Please choose a gender: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Gender you schoose: " + gender);

            #endregion

            Console.Read();
        }
    }
}
