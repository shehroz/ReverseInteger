using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x=1234;
            //int x = 1534236469;
            int x = -123;
            Console.WriteLine(ReverseInteger(x));
            Console.ReadKey();
        }
        public static int ReverseInteger(int x)
        {
            string xStr = x.ToString();
            bool IsNegativeNum = false;
            
            StringBuilder str = new StringBuilder();
            for (int i =xStr.Length - 1; i >= 0; i--)
            {
                if (xStr[i] != '-')
                    str.Append(xStr[i]);
                else
                    IsNegativeNum = true;
            }
            try
            {
                var num = checked(Int32.Parse(str.ToString()));
                if (IsNegativeNum)
                    return num *= (-1);
                return num;
            }
            catch (Exception)
            {

                return 0;
            }
            
        }
    }
}
