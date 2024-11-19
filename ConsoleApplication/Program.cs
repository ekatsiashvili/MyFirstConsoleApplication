using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the nominal of the trade:");
            string userInput1 = Console.ReadLine();
            int nominal = Int32.Parse(userInput1);

            Console.WriteLine("Input the price of the trade:");
            string userInput2 = Console.ReadLine();
            double price = double.Parse(userInput2);

            TransactionType trcType;
            Console.WriteLine("Please write the type of Transaction: Buy or Sell");
            string userInput3 = Console.ReadLine();
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput3, true);

            int sign = (trcType == TransactionType.Buy) ? 1 : -1;
            double currentValue = (double) sign * nominal * price;

            Console.WriteLine($"The current value equals: {currentValue}");

            Console.ReadKey();
        }
    }
}
