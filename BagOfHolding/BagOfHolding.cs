using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{ 
    // Generic MyGame class that can hold any type of GameItem
    public class BagOfHolding<T> where T : GameItem
    {

        // Internal list to store items
        private List<T> _items;

        public List<T> Items
        {
            get { return _items; }
            private set { _items = value; }
        }

        // Constructor to initialize the bag
        public BagOfHolding()
        {
            _items = new List<T>();
        }

        // Method to add an item to the bag
        public void Add(T item)
        {
            _items.Add(item);
        }

        // Method to remove an item from the bag by its ID
        public T Get(int id)
        {
            return _items.FirstOrDefault(i => i.Id.Equals(id));
        }


        // Method to remove an item from the bag by its ID
        public List<T> GetAll()
        {
            return _items;
        }

        // Method to remove an item from the bag by its ID
        public int Count()
        {
            return _items.Count;
        }
      
        public void ActivateKey(string name)
        {
            T item = _items.FirstOrDefault(i => i.Name.Equals(name));
            if (item is Key key)
            {
                key.Activate();
            }
            else
            {
                Console.WriteLine("No magical key found with that name.");
            }
        }













    }
}
