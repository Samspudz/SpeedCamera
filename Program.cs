/*
 *  author: Adam Marshall
 *  date: 02/10/2023
 *  class: GAME 1343
 *  project: Speed Camera
 */

namespace SpeedCamera
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // user input to set speed limit variable
            Console.WriteLine("Please enter the Speed Limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            // input for Car A
            Car a = new Car();
            Console.WriteLine("Please enter the Make for Car A: ");
            a.Make = Console.ReadLine();
            Console.WriteLine("Please enter the Model for Car A: ");
            a.Model = Console.ReadLine();
            Console.WriteLine("Please enter the Speed for Car A: ");
            a.Speed = Convert.ToInt32(Console.ReadLine());
            a.DemeritPoints = 0;

            // input for Car B
            Car b = new Car();
            Console.WriteLine("Please enter the Make for Car B: ");
            b.Make = Console.ReadLine();
            Console.WriteLine("Please enter the Model for Car B: ");
            b.Model = Console.ReadLine();
            Console.WriteLine("Please enter the Speed for Car B: ");
            b.Speed = Convert.ToInt32(Console.ReadLine());
            b.DemeritPoints = 0;

            // input for Car C
            Car c = new Car();
            Console.WriteLine("Please enter the Make for Car C: ");
            c.Make = Console.ReadLine();
            Console.WriteLine("Please enter the Model for Car C: ");
            c.Model = Console.ReadLine();
            Console.WriteLine("Please enter the Speed for Car C: ");
            c.Speed = Convert.ToInt32(Console.ReadLine());
            c.DemeritPoints = 0;

            // output for speed limit
            Console.WriteLine("Speed Limit: " + speedLimit + "mph");

            // Car A if/else statements for determining demerit points and output
            if (a.Speed > speedLimit)
            {
                while (a.Speed > speedLimit)
                {
                    a.Speed -= 5;
                    a.DemeritPoints++;
                }

                if (a.DemeritPoints < 10)
                {
                    Console.WriteLine(a.Make + " " + a.Model + " " + a.Speed + "mph: " + a.DemeritPoints + " Demerits");
                }

                else
                {
                    Console.WriteLine(a.Make + " " + a.Model + " " + a.Speed + ": " + a.DemeritPoints + " <LICENSE SUSPENDED>");
                }

            }

            else
            {
                Console.WriteLine(a.Make + " " + a.Model + " " + a.Speed + ": OK");
            }

            // Car B if/else statements for determining demerit points and output
            if (b.Speed > speedLimit)
            {
                while (b.Speed > speedLimit)
                {
                    b.Speed -= 5;
                    b.DemeritPoints++;
                }

                if (b.DemeritPoints < 10)
                {
                    Console.WriteLine(b.Make + " " + b.Model + " " + b.Speed + "mph: " + b.DemeritPoints + " Demerits");
                }

                else
                {
                    Console.WriteLine(b.Make + " " + b.Model + " " + b.Speed + ": " + b.DemeritPoints + " <LICENSE SUSPENDED>");
                }

            }

            else
            {
                Console.WriteLine(b.Make + " " + b.Model + " " + b.Speed + ": OK");
            }

            // Car C if/else statements for determining demerit points and output
            if (c.Speed > speedLimit)
            {
                while (c.Speed > speedLimit)
                {
                    c.Speed -= 5;
                    c.DemeritPoints++;
                }

                if (c.DemeritPoints < 10)
                {
                    Console.WriteLine(c.Make + " " + c.Model + " " + c.Speed + "mph: " + c.DemeritPoints + " Demerits");
                }

                else
                {
                    Console.WriteLine(c.Make + " " + c.Model + " " + c.Speed + ": " + c.DemeritPoints + " <LICENSE SUSPENDED>");
                }

            }

            else
            {
                Console.WriteLine(c.Make + " " + c.Model + " " + c.Speed + ": OK");
            }
        }
    }

    //Car class to store variables
    public class Car
    {
        private string make;
        private string model;
        private int speed;
        private int demeritPoints;

        public string Make
        {
            get => make;
            set => make = value;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }

        public int Speed
        {
            get => speed;
            set=> speed = value;
        }

        public int DemeritPoints
        {
            get => demeritPoints;
            set => demeritPoints = value;
        }
    }
}