using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            System.Console.WriteLine($"1.{today.ToString("MMMM")} {today.ToString("dd")}, {today.ToString("yyyy")}");
            System.Console.WriteLine($"2.{today.ToString("yyyy")}.{today.ToString("MM")}.{today.ToString("dd")}");
            System.Console.WriteLine($"3.Day {today.ToString("dd")} of {today.ToString("MMMM")}, {today.ToString("yyyy")}");
            System.Console.WriteLine($"4.Year:{today.ToString("yyyy")},Month:{today.ToString("MM")},Day:{today.ToString("dd")}");
            System.Console.WriteLine($"5.{today.ToString("dddd"), 10}");
            System.Console.WriteLine($"6.{today.ToString("hh")}:{today.ToString("mm")}          {today.ToString("dddd")}");
            System.Console.WriteLine($"7.h:{today.ToString("hh")}, m:{today.ToString("mm")}, s:{today.ToString("ss")}");
            System.Console.WriteLine($"8.{today.ToString("yyyy")}.{today.ToString("MM")}.{today.ToString("dd")}.{today.ToString("hh")}.{today.ToString("mm")}.{today.ToString("ss")}");
            var pi = 3.1415;
            System.Console.WriteLine("1. {0:c}", pi);
            System.Console.WriteLine("2. {0, 10:N3}", pi);
        }
    }
}
