using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        //   Reverse Number
        // Number = 12345
        // Reverse = 54321
        static void Main(string[] args)
        {
            int n = 12345, rev = 0;
            
            while(n!=0)
            {
                rev = rev * 10;
                rev = rev + n % 10;
                n = n / 10;
            }
            Console.WriteLine(rev);
        

        }
    }


