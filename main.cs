using System;

namespace GreenvilleRevenue
{
    class Program
    {
        const int REVENUE_PER_CONTESTANT = 25;

        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMotto();
                DisplayMenu();
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    CalculateRevenue();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

        static void DisplayMotto()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*  The stars shine in Greenville.  *");
            Console.WriteLine("************************************");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nPlease Enter the following number below from the following menu:");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit");
        }

        static void CalculateRevenue()
        {
            Console.Write("Enter number of contestants last year: ");
            int lastYearContestants = int.Parse(Console.ReadLine());

            Console.Write("Enter number of contestants this year: ");
            int thisYearContestants = int.Parse(Console.ReadLine());

            int thisYearRevenue = thisYearContestants * REVENUE_PER_CONTESTANT;

            Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants");
            Console.WriteLine($"Revenue expected this year is ${thisYearRevenue:N0}");

            if (thisYearContestants > lastYearContestants)
            {
                Console.WriteLine("It is true that this year's competition is bigger than last year's.");
            }
            else
            {
                Console.WriteLine("It is false that this year's competition is bigger than last year's.");
            }

            Console.WriteLine();
        }
    }
}
