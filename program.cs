using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxpayer[] taxpayers = new Taxpayer[10];

            for (int i = 0; i < 10;i++)
            {
                Console.WriteLine("Enter social security number of subject #{0}.", i+1);
                //taxpayers[i].SocialSec = double.Parse(Console.ReadLine());
                taxpayers[i].SocialSec = 10;
            

                Console.WriteLine("Enter yearly income of subject #{0}.", i + 1);
                taxpayers[i].Income = double.Parse(Console.ReadLine());

                Console.WriteLine("The tax owed is {0}", taxpayers[i].OwedTax);
            }


        }
    }
}
