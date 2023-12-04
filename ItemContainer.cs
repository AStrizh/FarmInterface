using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInterface
{
    public class ItemContainer : AbstractItem
    {
        public List<ElementalUnit> Children { get; private set; } = new List<ElementalUnit>();

        public ItemContainer(string name, decimal purchasePrice, int locationX, int locationY, double length, double width, double height)
    : base(name, purchasePrice, locationX, locationY, length, width, height) { }

        public void AddItem(ElementalUnit item) {
            item.Parent = this;
            Children.Add(item);         
        }

        public override void Delete(ElementalUnit unit)
        {
            if (unit == this && unit.Parent != null)
            {
                foreach (var child in Children.ToList())
                {
                    ((ItemContainer) Parent).AddItem(child);
                    child.Parent = Parent;
                }
                Parent.Delete(this);
            }

            else
            {
                Children.Remove(unit);
            }
        }

        public override void Accept(IElementVisitor visitor)
        {
            visitor.VisitItemContainer(this);
            foreach (var child in Children)
            {
                child.Accept(visitor); // Recursive call
            }
        }

    }
}
