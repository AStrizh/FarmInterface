using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInterface
{
    public class PricingVisitor : IElementVisitor
    {
        public decimal TotalPurchasePrice { get; private set; }
        public decimal TotalCurrentPrice { get; private set; }

        public void VisitItem(Item item)
        {
            TotalPurchasePrice += item.PurchasePrice;
            TotalCurrentPrice += item.CurrentPrice;
        }

        public void VisitItemContainer(ItemContainer container)
        {
            TotalPurchasePrice += container.PurchasePrice;
            // Note: Current price is not added for containers
        }
    }

}
