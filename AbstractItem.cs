using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInterface
{
    public class AbstractItem : ElementalUnit
    {
        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public ElementalUnit Parent { get; set; }

        protected AbstractItem(string name, decimal purchasePrice, int locationX, int locationY, double length, double width, double height)
        {
            Name = name;
            PurchasePrice = purchasePrice;
            LocationX = locationX;
            LocationY = locationY;
            Length = length;
            Width = width;
            Height = height;
        }

        public virtual void Delete(ElementalUnit unit)
        {
            Parent?.Delete(unit);
        }
    }
}
