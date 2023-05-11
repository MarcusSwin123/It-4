using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace SwinAdventure_It_3
{
    public class GameObject : IdentifiableObject
    {
        private string _description, _name;
        public GameObject(string[] ids, string name, string description) :base(ids)
        {
            _description = description;
            _name = name;
        }
        public string Name 
        { 
            get 
            { 
                return _name.ToLower(); 
            }
        }
        public virtual string FullDescription
        {
            get
            { 
                return _description;
            }
        }
        public string ShortDescription
        {
            get
            {
                return $"{Name} ({FirstId})";
            }
        }
    }
}
