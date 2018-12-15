using System;
using System.Collections.Generic;
using System.Text;
using csharpcore.Abstraction;

namespace csharpcore.Concrete
{
    /// <summary>
    /// It is Legendary items, never changes
    /// </summary>
    public class LegendaryItem:BaseItem
    {
        protected override void UpdateQuality(){}

        protected override void UpdateSellIn(){}

        protected override void HandleExpired(){}
    }
}
