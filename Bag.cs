using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure_It_3
{
    public class Bag : Item
    {
        Inventory _inventory = new Inventory();

        public Bag(string[] idents, string name, string description) : base(idents, name, description)
        {

        }
        
        public Inventory Inventory
        {
            get { return _inventory; } 
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            else
            {
                return _inventory.Fetch(id);
            }
        }
        public override string FullDescription
        {
            get
            {
                return $"In the {Name} you can see:\n{_inventory.ItemList}";
            }
        }
    }
}
