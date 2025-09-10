using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Weapon : GameItem
    {
        // Damage provided by the weapon
        private int _damage;

        // Damage property
        public int Damage
        {
            get { return _damage; }
            private set { _damage = value; }
        }

        // Constructor to initialize the weapon item
        public Weapon(string name, int damage) : base(name)
        {
            _damage = damage;
            Name = name;
        }


        // Override ToString method for easy display
        public override string ToString()
        {
            return $"Weapon: {Name} (Damage: {Damage})";
        }
    }
}
