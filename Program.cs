using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           double [] nums = {1.25, 1241.53, 5.44, 90.21, 6.51};

           foreach(double num in nums)
           {
               Console.Write("{0} ", num.ToString("N2"));
           }

           Console.WriteLine();

           Console.ReadLine();
        } 
    }
}
