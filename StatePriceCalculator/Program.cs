using System;

namespace StatePriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfItems;
            double itemPrice;
            double totalPrice;
            double totalPriceDiscount = 0;
            string stateCode;
            double totalPriceTax = 0;

            // Velkommen til brugere

            Console.WriteLine("Velkommen til");

            // Bruger taster antal varer

            Console.WriteLine("Tast antal varer:");
            numberOfItems = Convert.ToInt32(Console.ReadLine());

            // Bruger taster pris på én vare

            Console.WriteLine("Tast pris på varen:");
            itemPrice = Convert.ToInt32(Console.ReadLine());

            // Giv bruger samlet pris

            totalPrice = numberOfItems * itemPrice;
            Console.WriteLine($"Den samlede pris uden discount og tax er: { totalPrice}");

            // Bruger skal vælge: Er du færdig? JA / NEJ


            // Hvis bruger trykker NEJ, køres "Bruger taster antal varer" igen

            // Udregn samlet pris med discount

            if (totalPrice <= 999)
            {
                Console.WriteLine("Der er ingen discount");
            }
            else if (totalPrice >= 1000 && totalPrice < 4999)
            {
                totalPriceDiscount = totalPrice * 0.97;
                Console.WriteLine("Discount: 3%");
            }
            else if (totalPrice >= 5000 && totalPrice < 6999)
            {
                totalPriceDiscount = totalPrice * 0.95;
                Console.WriteLine("Discount: 5%");
            }
            else if (totalPrice >= 7000 && totalPrice < 9999)
            {
                totalPriceDiscount = totalPrice * 0.93;
                Console.WriteLine("Discount: 7%");
            }
            else if (totalPrice >= 10000 && totalPrice < 49999)
            {
                totalPriceDiscount = totalPrice * 0.90;
                Console.WriteLine("Discount: 10%");
            }
            else
            {
                totalPriceDiscount = totalPrice * 0.85;
                Console.WriteLine("Discount: 15%");
            }

            // Besked om samlet pris med discount

            Console.WriteLine($"Den samlede pris med discount, men uden tax er: {totalPriceDiscount}");

            // Besked: Tast State-code, 2 letters

            Console.WriteLine("Tast State-code (2 letters):");

            // Bruger taster State-code, 2 letters

            stateCode = Console.ReadLine();

            // Udregn tax

            switch (stateCode)
            {
                case "UT":
                    totalPriceTax = totalPriceDiscount * 1.0685;
                    Console.WriteLine("Din stats tax: 6,85%");
                    break;
                case "NV":
                    totalPriceTax = totalPriceDiscount * 1.08;
                    Console.WriteLine("Din stats tax: 8,0%");
                    break;
                case "TX":
                    totalPriceTax = totalPriceDiscount * 1.0625;
                    Console.WriteLine("Din stats tax: 6,25%");
                    break;
                case "AL":
                    totalPriceTax = totalPriceDiscount * 1.04;
                    Console.WriteLine("Din stats tax: 4,0%");
                    break;
                case "CA":
                    totalPriceTax = totalPriceDiscount * 1.0825;
                    Console.WriteLine("Din stats tax: 8,25%");
                    break;
                default:
                    Console.WriteLine("Du har indtastet en forkert stat");
                    break;
            }

            // Besked til bruger om samlet pris

            Console.WriteLine($"Den samlede pris på din bestilling efter discount og tax er: {totalPriceTax}");
        }
    }
}
