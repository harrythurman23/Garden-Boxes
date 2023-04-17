using System;

namespace GardenBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            //In this example you can plant 1 carrot per square foot, 3 corn per 16 square feet, and 9 beets per 16 square feet

            Console.WriteLine("Hello There! What's the length of the garden box in feet?");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's the width of the garden box?");
            int width = Convert.ToInt32(Console.ReadLine());
            int area = (length * width);
            Console.WriteLine("The area of your box is " + (area) + " square feet");
            Console.WriteLine("The perimiter of your box is " + ((length * 2) + (width * 2)) + " feet");
            Console.WriteLine("You can plant " + (area) + " carrots");
            Console.WriteLine("You can plant " + (3 * (area / 16.00)) + " corn");
            Console.WriteLine("You can plant " + (9 * (area / 16.00)) + " beets");
        }
    }
}
