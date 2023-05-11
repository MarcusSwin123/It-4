using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace SwinAdventure_It_3
{
    public class Inventory
    {
        List<Item> _items;
        public Inventory() 
        {
            _items = new List<Item>(); //list of items in inventory, initialised in the setup
        }
        public bool HasItem(string id)
        {
            foreach (Item item in _items) 
            {
                if (item.AreYou(id))
                    return true;
            }
            return false;
        }
        public Item Fetch(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    return item;
                }
            }
            return null;
        }
        public void Put(Item item)
        {
            _items.Add(item);
        }
        public Item Take(string id) 
        {
            Item item1 = Fetch(id);

                _items.Remove(item1);
                return item1;
        }
        public string ItemList
        {
            get
            {
                string ItemListString = ""; 

                foreach (Item item in _items)
                {
                    ItemListString += $"\t{item.ShortDescription}\n";
                }
                return ItemListString;
            }
        }

    }
}
