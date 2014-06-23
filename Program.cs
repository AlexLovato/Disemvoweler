using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2codingprojectFINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Disemvowel Function Calls 
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");

            //ChangeMaker Function Calls
            ChangeMaker(3.18);
            ChangeMaker(.99);
            ChangeMaker(100.93);

        }


        static void Disemvoweler(string sentence11)
        {
            //remove vowels from string
            string correctString = sentence11.Replace(" ", "");
            correctString = correctString.Replace("a", "");
            correctString = correctString.Replace("e", "");
            correctString = correctString.Replace("i", "");
            correctString = correctString.Replace("o", "");
            correctString = correctString.Replace("u", "");
            Console.WriteLine("Original: " + sentence11);
            Console.WriteLine("Disemvoweled: " + correctString);

            //remove cconsonants and special characters
            Console.ReadKey();
            string sentence111 = sentence11;
            sentence111 = sentence111.ToLower();
            sentence111 = sentence111.Replace("b", "");
            sentence111 = sentence111.Replace("c", "");
            sentence111 = sentence111.Replace("k", "");
            sentence111 = sentence111.Replace("d", "");
            sentence111 = sentence111.Replace("j", "");
            sentence111 = sentence111.Replace("f", "");
            sentence111 = sentence111.Replace("g", "");
            sentence111 = sentence111.Replace("h", "");
            sentence111 = sentence111.Replace("l", "");
            sentence111 = sentence111.Replace("m", "");
            sentence111 = sentence111.Replace("n", "");
            sentence111 = sentence111.Replace("p", "");
            sentence111 = sentence111.Replace("q", "");
            sentence111 = sentence111.Replace("r", "");
            sentence111 = sentence111.Replace("s", "");
            sentence111 = sentence111.Replace("t", "");
            sentence111 = sentence111.Replace("v", "");
            sentence111 = sentence111.Replace("w", "");
            sentence111 = sentence111.Replace("x", "");
            sentence111 = sentence111.Replace("y", "");
            sentence111 = sentence111.Replace("z", "");
            sentence111 = sentence111.Replace("!", "");
            sentence111 = sentence111.Replace("?", "");
            sentence111 = sentence111.Replace("#", "");
            sentence111 = sentence111.Replace("@", "");
            sentence111 = sentence111.Replace(",", "");
            sentence111 = sentence111.Replace("*", "");
            sentence111 = sentence111.Replace(" ", "");
            sentence111 = sentence111.Replace(".", "");
            sentence111 = sentence111.Replace("'", "");
            Console.WriteLine("Vowels: " + sentence111);
            Console.ReadKey();
        }
        static void ChangeMaker(double number)
        {
            double hundred = 100;
                double fifty = 50;
                double twenty = 20;
                double ten = 10;
                double five = 5;
                double one = 1;
            double quarter = .25;
            double nickel = .05;
            double dime = .1;
            double penny = .01;
            decimal hundredD = (decimal)hundred;
            decimal fiftyD = (decimal)fifty;
            decimal twentyD = (decimal)twenty;
            decimal tenD = (decimal)ten;
            decimal fiveD = (decimal)five;
            decimal oneD = (decimal)one;
            decimal nickelD = (decimal)nickel;
            decimal dimeD = (decimal)dime;
            decimal pennyD = (decimal)penny;
            decimal quarterD = (decimal)quarter;
            decimal numberD = (decimal)number;
            decimal numberofHs = numberD / hundredD;
            decimal after100s = numberD % hundredD;
            decimal numberofQs = after100s / quarterD;
            decimal numAfter25 = after100s % quarterD;
            decimal numberofDs = numAfter25 / dimeD;
            decimal numAfter10 = numAfter25 % dimeD;
            decimal numberofNs = numAfter10 / nickelD;
            decimal numAfter5 = numAfter10 % nickelD;
            decimal numberofPs = numAfter5 / pennyD;
            decimal numAfter1s = numAfter5 % pennyD;
            int h = (int)numberofHs;
            int q = (int)numberofQs;
            decimal.Round(numAfter25,2);
            int d = (int)numberofDs;
            int n = (int)numberofNs;
            int p = (int)numberofPs;
            Console.WriteLine("number of hundreds: " + h);
            Console.WriteLine("number of quarters: " + q);
                Console.WriteLine("number of dimes: " + d);
                Console.WriteLine("number of nickels: " + n);
                Console.WriteLine("number of pennies: " + p);
                Console.ReadKey();
        }

        }
      
    }

