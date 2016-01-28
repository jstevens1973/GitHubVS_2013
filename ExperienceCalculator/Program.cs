using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime Value1;
            DateTime Value2;

                if (DateTime.TryParse("January 2013", out Value1)){

                Console.WriteLine(Value1.Month);
            

                }else{
                    Console.WriteLine ("Error");
                }
            Console.ReadLine();
        }
    }
}
