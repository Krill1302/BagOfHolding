using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public abstract class GameItem
    {

        public string Name { get; protected set; }

        // _id: int {+Get; -Set}
        public int Id { get; private set; }

        // _nextId: int = 1 {static, private}
        private static int _nextId = 1;

        // + GameItem()
        protected GameItem()
        {
            this.Name = string.Empty;
            this.Id = _nextId++;
        }

        // + GameItem(String name)
        protected GameItem(string name)
        {
            this.Name = name;
            this.Id = _nextId++;
        }

        // + ToString(): String
        public override string ToString()
        {
            return "#" + Id + " " + Name;
        }
    }





}

