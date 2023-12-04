using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInterface
{
    internal class Item : AbstractItem
    {
        //All functions inherited from parent
        public Item(string name, decimal purchasePrice, decimal currentPrice, int locationX, int locationY, double length, double width, double height)
    : base(name, purchasePrice, currentPrice, locationX, locationY, length, width, height) { }
    }
}
