using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Gizmo
    {
        //Fields

        private bool afterMidnight;
        private bool spilledOnGizmo;
        private bool isLightOut;
        private int boredomLevel;
        private int foodAmount;
        private int hungerLevel;
        private int thirstLevel;
        private int activityAmount;
        private int beverageAmount;

        //Properties

        public bool AfterMidnight
        {
            get { return this.afterMidnight; }
            set { this.afterMidnight = value; }
        }
        
        public bool SpilledOnGizmo
        {
            get { return this.spilledOnGizmo; }
            set { this.spilledOnGizmo = value;  }
        }

        public bool IsLightOut
        {
            get { return this.isLightOut; }
            set { this.isLightOut = value; }
        }

        public int BeverageAmount
        {
            get { return this.beverageAmount; }
            set { this.beverageAmount = value; }
        }

        public int FoodAmount
        {
            get { return this.foodAmount; }
            set { this.foodAmount = value; }
        }

        public int ActivityAmount
        {
            get { return this.activityAmount; }
            set { this.activityAmount = value; }
        }

        public int BoredomLevel
        {
            get { return this.boredomLevel; }
            set { this.boredomLevel = value; }
        }

        public int ThirstLevel
        {
            get { return this.thirstLevel; }
            set { this.thirstLevel = value; }
        }

        public int HungerLevel
        {
            get { return this.hungerLevel; }
            set { this.hungerLevel = value; }
        }

        //Constructors

        public Gizmo() { }

        public Gizmo(int hungerLevel, int thirstLevel, int boredomLevel)
        {
            this.hungerLevel = hungerLevel;
            this.thirstLevel = thirstLevel;
            this.boredomLevel = boredomLevel;
        }

        public int FeedGizmo()
        {
            if (hungerLevel >= 1)
            {
                Console.WriteLine("Gizmo has been fed.");
                
                Console.WriteLine("Is it after midnight? (type True or False)");
                afterMidnight = bool.Parse(Console.ReadLine());

                if (afterMidnight == true)
                {
                    Console.WriteLine("Gizmo is now a gremlin!");
                    Console.WriteLine("");
                }

                else
                {
                    Console.WriteLine("All is good.");
                    Console.WriteLine("");
                    
                }
                return hungerLevel-- + thirstLevel++;
            }
            else
            {
                Console.WriteLine("Gizmo does not need to be fed.");
                Console.WriteLine("");
                return hungerLevel++;
            }
        }
            public int WaterGizmo()
            {
                if (thirstLevel >= 1)
                {
                    Console.WriteLine("Gizmo has been given some water.");
                    
                    Console.WriteLine("Did you spill on Gizmo? (type True or False)");
                    spilledOnGizmo = bool.Parse(Console.ReadLine());

                    if (spilledOnGizmo == true)
                    {
                        Console.WriteLine("Gizmo is now a gremlin!");
                        Console.WriteLine("");
                }

                    else
                    {
                        Console.WriteLine("All is good.");
                        Console.WriteLine("");
                        
                }
                return thirstLevel--;
            }

                else
                {
                    Console.WriteLine("Gizmo does not need anything to drink.");
                    return thirstLevel++;
                }
            }

            public int ActivateGizmo()
            {
                if (boredomLevel >= 1)
                {
                    Console.WriteLine("Gizmo has been allowed out to play");
                    
                    Console.WriteLine("Is it light out? (type True or False)");
                    isLightOut = bool.Parse(Console.ReadLine());

                    if (isLightOut == true)
                    {
                        Console.WriteLine("That hurt Gizmo! Quick! Get back inside!");
                        Console.WriteLine("");
                        return hungerLevel++ + thirstLevel++ + boredomLevel++;
                    }

                    else
                    {
                        Console.WriteLine("All is good!");
                        Console.WriteLine("");
                        return boredomLevel-- + hungerLevel++ + thirstLevel++;
                    }
                }

                else
                {
                    Console.WriteLine("Gizmo needs to sleep.");
                    return boredomLevel++;
                }
            }
                
        
        

    }
}
