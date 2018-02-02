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

        private bool isHungry;
        private bool afterMidnight;
        private bool spilledOnGizmo;
        private bool isLightOut;
        private bool isThirsty;
        private bool isBored;
        private int boredomLevel;
        private int foodAmount;
        private int hungerLevel;
        private int thirstLevel;
        private int activityAmount;
        private int beverageAmount;

        //Properties

        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public bool IsThirsty
        {
            get { return this.isThirsty; }
            set { this.isThirsty = value; }
        }

        public bool IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value;  }
        }

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



    }
}
