using System;
using System.Collections.Generic;

namespace ceshi2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*String a = new String("2093099");
            //Console.WriteLine("1111111");
            if (!a.Equals("2093101") && !a.Equals("2093099"))
            {
                Console.WriteLine("tr");
            }
            else
            {
                Console.WriteLine("fa");
            }*/
            List<int> a = new List<int>() { 1,2,3,4};
            int b = 6;
            /*for(int i = a[0]; i<=a.Count; i++)
            {
                if (i == b)
                {
                    Console.WriteLine("1111111");
                }
                else
                {
                    Console.WriteLine("222");
                }
            }*/
            /*foreach (int c in a)
            {
               
                if(c == b)
                {
                    Console.WriteLine("1111111");
                }
                else
                {
                    Console.WriteLine("222");
                }
            }*/
            bool isCon = a.Contains(b);
            if (isCon)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine("111111111111111111111");
                Console.WriteLine("111111111111111111111");
            }
            
        }
    }
}
