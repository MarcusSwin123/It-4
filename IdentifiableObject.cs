using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;


namespace SwinAdventure_It_3
{
    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();
        public IdentifiableObject(string[] idents)
        {
            foreach(string ident in idents) 
            {
                _identifiers.Add(ident.ToLower());
            }
        }
        public string FirstId
        {
            get
            {
                if (_identifiers.Count == 0)
                {
                    return "";
                }
                return _identifiers.First();
            }
        }

        public bool AreYou(string id)
        {
            return _identifiers.Contains(id);
        }
        public void AddIdentifier(string identifier)
        {
            _identifiers.Add(identifier.ToLower());
        }
    }
}