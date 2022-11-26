using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_roman
{
    internal class Program
    {
        static public string IntToRoman(int num)
        {
            int count = 0;
            string roman = "";


            while (num >= 1000) { count++; num -= 1000; }
            for (int i = 0; i < count; i++) { roman += "M"; }
            count = 0;



            while (num >= 100) { count++; num -= 100; }
            if (count == 9) { roman += "CM"; }
            else if (count >= 5)
            {
                roman += "D";
                count -= 5;
                for (int i = 0; i < count; i++)
                {
                    roman += "C";
                }
            }
            else if (count == 4)
            {
                roman += "CD";
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    roman += "C";
                }
            }
            count = 0;



            while (num >= 10) { count++; num -= 10; }
            if (count == 9) { roman += "XC"; }
            else if (count >= 5)
            {
                roman += "L";
                count -= 5;
                for (int i = 0; i < count; i++)
                {
                    roman += "X";
                }
            }
            else if (count == 4)
            {
                roman += "XL";
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    roman += "X";
                }
            }
            count = 0;




            while (num >= 1) { count++; num -= 1; }
            if (count == 9) { roman += "IX"; }
            else if (count >= 5)
            {
                roman += "V";
                count -= 5;
                for (int i = 0; i < count; i++)
                {
                    roman += "I";
                }
            }
            else if (count == 4)
            {
                roman += "IV";
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    roman += "I";
                }
            }
            count = 0;

            return roman;
        }
        static void Main(string[] args)
        {
            string val = IntToRoman(2949);
            Console.WriteLine(val);
            Console.ReadKey();
        }

      
        }

    }
