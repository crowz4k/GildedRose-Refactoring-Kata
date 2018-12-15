using csharpcore.Abstraction;

namespace csharpcore.Concrete
{
    public class ConcertItem:BaseItem
    {
        protected override void UpdateQuality()
        {
            IncrementQuality();

            if (Item.SellIn <= Constants.DAYS_BEFORE_CONCERT)
            {
                IncrementQuality();
            }

            if (Item.SellIn <= Constants.DAYS_BEFORE_CONCERT_RUSH)
            {
                IncrementQuality();
            }
        }

        protected override void HandleExpired()
        {
            Item.Quality = 0;
        }
    }
}
