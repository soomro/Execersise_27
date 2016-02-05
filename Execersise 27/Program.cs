using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execersise_27
{
    class Program
    {
        static void Main(string[] args)
        {/* Mouhammad  

            // Take input
            Console.WriteLine("Please enter the number that you need the divisible numbers for");
            int number = int.Parse(Console.ReadLine());
            int moduloResult;
            // iterate all values possible of number &
            // store modulos %
            string allDivisibleNumbers = "";
            for (int i = 1; i <= number; i++)
            {
                moduloResult = number % i;
                if (moduloResult == 0)
                {
                    string m = i.ToString();
                    allDivisibleNumbers = allDivisibleNumbers + " " + m;
                }
                //else
                //{
                //    Console.WriteLine("please enter the number that is positiv");
                //}
              //Console.Clear();
             //   Console.WriteLine("the output is {0}", allDivisibleNumbers);
            }
            Console.WriteLine("the output is {0}.", allDivisibleNumbers);
            Console.ReadKey();
            */

            // Wassem 
            

                        string allDivisibleNumbers = "";
                        for (int i = 1; i <= number; i++)
                        {
                            moduloResult = number % i;
                            if (moduloResult == 0)
                            {
                                string m = i.ToString();
                                allDivisibleNumbers = allDivisibleNumbers + m;
                                if (i != number)
                                {
                                    allDivisibleNumbers = allDivisibleNumbers + ",";
                                }
                            }
                            //else
                            //{
                            //    Console.WriteLine("please enter the number that is positiv");
                            //}
                            //Console.Clear();
                            //   Console.WriteLine("the output is {0}", allDivisibleNumbers);
                        }
                        Console.WriteLine("the output is {0}.", allDivisibleNumbers);
                        Console.ReadKey(); 
        }
    }
}
