using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInterface
{
    public interface IElementVisitor
    {
        void VisitItem(Item item);
        void VisitItemContainer(ItemContainer container);
    }
}
