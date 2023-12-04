using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInterface
{
    internal class Item : AbstractItem
    {

        public decimal CurrentPrice { get; set; }

        public Item(string name, decimal purchasePrice, decimal currentPrice, int locationX, int locationY, double length, double width, double height)
            : base(name, purchasePrice, locationX, locationY, length, width, height)
        {
            CurrentPrice = currentPrice;
        }
    }
}
