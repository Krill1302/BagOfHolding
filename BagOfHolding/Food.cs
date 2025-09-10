using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Food : GameItem
    {

        private int _energy;

        // Energy provided by the food item
        public int Energy
        {
            get { return _energy; }
            private set { _energy = value; }
        }

        // Constructor to initialize the food item
        public Food(string name, int energy) : base(name)
        {
            _energy = energy;
            Name = name;

        }

        public Food() { }

        // Override ToString method for easy display
        public override string ToString()
        {
            return $"Food: {Name} (Energy: {Energy})";
        }


    }
}
