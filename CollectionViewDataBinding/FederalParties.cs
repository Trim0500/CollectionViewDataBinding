using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionViewDataBinding
{
    public class FederalParties
    {
        public string name { get; set; }
        public string leader { get; set; }
        public string imageURL { get; set; }
        public override string ToString()
        {
            return name + " " + leader;
        }
    }
}
