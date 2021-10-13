using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionViewDataBinding
{
    //Step-02: Create Fruit class (standard POJO)
    public class Fruit
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {

            return Name + " " + Color;
        }
    }
}
