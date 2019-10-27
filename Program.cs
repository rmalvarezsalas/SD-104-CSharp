using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatingAverage
{
    class Program
    {
        
        static void Main(string[] args)            
        {
            Console.WriteLine("Enter the Players name");
            string strName=Console.ReadLine();
            Console.WriteLine("Enter the Number of Hits");
            double nHits = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the Number of Bats");
            double nBats = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(strName + "'S Batting Average is: " + nHits/nBats);
            Console.WriteLine("{0}'s Batting Average is {1}", strName, nHits/nBats);
            Console.ReadLine();

        }
    }
}
