using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace SwinAdventure_It_3
{
    public class Player : GameObject
    {
        private Inventory _inventory;
        public Player(string name, string description)  :base(new string[] {"me", "inventory"}, name, description)//use like set up to declare
        {
             _inventory = new Inventory();
        }
        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return _inventory.Fetch(id);
        }
        public Inventory Inventory
        {
            get { return _inventory; }
        }
        public override string FullDescription
        {
            get
            {
                return $"You are {Name}, {base.FullDescription}.\nYou are carrying:\n{Inventory.ItemList}";
            }
        }
    }
}
