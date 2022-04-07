using System;
using System.Collections.Generic;

namespace task5var22
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Sport> sports = new List<Sport>();
            
            sports.Add(new Soccer("Пляжный футбол",
                0.2, 5,2, 100, 0));
            sports.Add(new Soccer("Большой футбол",
                0.7, 11,2, 5000, 1000));

            foreach (Sport s in sports)
            {
                Console.WriteLine(s);
            }
        }
    }
}