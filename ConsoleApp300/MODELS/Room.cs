using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp300.MODELS
{
    class Room
    {
        private string v1;
        private double v2;
        private int v3;

        public int ID { get; set; }
        public string Name { get; set; }
        public double Price
        {
            get
            {
                return Price;
            }
            set
            {
                if (value > 0)
                {
                    Price = value;
                }
            }
        }

        public int PersonCapacity

        {
            get
            {
                return PersonCapacity;
            }
            set
            {
                if (value > 0)
                {
                    PersonCapacity = value;
                }
            }
        }

        public bool IsAvailable { get; set; } = true;

        public int PlusId()
        {
            ID++;
            return ID;
        }

        public Room(string Name, int Price, int PersonCapacity)
        {
            this.Name = Name;
            this.Price = Price;
            this.PersonCapacity = PersonCapacity;
            ID = PlusId();
        }

        public Room(string v1, double v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public string ShowInfo()
        {
            return $"{Name}-{Price}-{PersonCapacity}-{IsAvailable}";

        }
        public override string ToString()
        {
            return ShowInfo();

        }
    }
}