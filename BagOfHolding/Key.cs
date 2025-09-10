using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    // Key class inheriting from GameItem and implementing IMagical interface
    public class Key : GameItem, IMagical
    {
        // Size of the key
        private int _size;

        // Size property
        public int Size
        {
            get { return _size; }
            private set { _size = value; }
        }

        // Constructor to initialize the key item
        public Key(string name, int size) : base(name)
        {
            _size = size;
            Name = name;

        }


        // Method to activate the magical key
        public void Activate()
        {
            Console.WriteLine("The key glows and unlocks a magical door!");
        }

        // Override ToString method for easy display
        public override string ToString()
        {
            return $"Key: {Name} (Size: {Size})";
        }
    }
}
