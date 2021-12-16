using System;

namespace AreaOfCircle_
{
    class Program
    {
        static void Main(string[] args)
        {

            AreaOfCircle();


        }
        public static void AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The radius of your circle is {Math.PI * Math.Pow(radius, 2)}");
            

        }
    }





}
