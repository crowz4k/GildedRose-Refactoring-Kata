using csharpcore.Abstraction;

namespace csharpcore.Concrete
{
    public class CommonItem : BaseItem
    {
        protected override void UpdateQuality()
        {
            DecrementQuality();
        }
    }
}
