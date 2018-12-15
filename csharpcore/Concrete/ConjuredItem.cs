using csharpcore.Abstraction;

namespace csharpcore.Concrete
{
    public class ConjuredItem:BaseItem
    {
        protected override void UpdateQuality()
        {
            DecrementQuality();
            DecrementQuality();
        }
    }
}
