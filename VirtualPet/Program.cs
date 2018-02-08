using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Gizmo userGizmo = new Gizmo(5, 5, 5);
            int userChoice;

            Console.WriteLine("Welcome to the Virtual Pet Tender App!");
            Console.WriteLine("Congratulations on your purchase of Gizmo the Mogwai");
            Console.WriteLine("");

            do
            {
                Console.WriteLine("Gizmo the Mogwai");
                Console.WriteLine("Hunger: " + userGizmo.HungerLevel + " out of 10");
                Console.WriteLine("Thirst: " + userGizmo.ThirstLevel + " out of 10");
                Console.WriteLine("Boredom: " + userGizmo.BoredomLevel + " out of 10");
                Console.WriteLine("");
                Console.WriteLine("What would you like to do for Gizmo?");
                Console.WriteLine("Feed Gizmo, type 1");
                Console.WriteLine("Give Gizmo something to drink, type 2");
                Console.WriteLine("Play with Gizmo, type 3");
                Console.WriteLine("To quit, type 4");

                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        userGizmo.FeedGizmo();
                        break;
                    case 2:
                        userGizmo.WaterGizmo();
                        break;
                    case 3:
                        userGizmo.ActivateGizmo();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye.");
                        break;
                }

                //tick
                userGizmo.HungerLevel++;//because of how this is set up levels can never go down. Consider making random.
                userGizmo.ThirstLevel++;
                userGizmo.BoredomLevel++; //need to make tick a method
            } while (userChoice != 4);
        }
    }
}
