using System;
using System.Collections.Generic;
using System.Text;
using csharpcore.Abstraction;

namespace csharpcore.Concrete
{
    public class CheeseItem : BaseItem
    {

        protected override void UpdateQuality()
        {
           IncrementQuality();
        }

        protected override void HandleExpired()
        {
            UpdateQuality();
        }
    }
}
