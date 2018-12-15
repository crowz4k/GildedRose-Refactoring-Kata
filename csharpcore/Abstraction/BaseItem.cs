namespace csharpcore.Abstraction
{
    /// <summary>
    /// BaseItem abstraction for Items in inventory.
    /// </summary>
    public abstract class BaseItem
    {
        #region Fileds
        #endregion

        #region Constructors

        protected BaseItem() { }

        protected BaseItem(Item item)
        {
            Item= item;
        }
        #endregion

        #region Methods

        public Item Item { get; set; }

        public void UpdateItem()
        {
            UpdateQuality();
            UpdateSellIn();

            if (Item.SellIn < 0)
            {
                HandleExpired();
            }
        }

        protected abstract void UpdateQuality();

        /// <summary>
        /// Updates SellIn property on Item
        /// </summary>
        protected virtual void UpdateSellIn()
        {
                Item.SellIn -= Constants.COMMON_DECREMENT;
        }

        /// <summary>
        /// Increments the quality
        /// </summary>
        protected void IncrementQuality()
        {
            if (Item.Quality < Constants.MAXIMUM_QUALITY)
            {
                Item.Quality+=Constants.COMMON_INCREMENTER;
            }
        }

        /// <summary>
        /// Decrements the quality 
        /// </summary>
        protected void DecrementQuality()
        {
            if (Item.Quality > Constants.MINIMUM_QUALITY)
            {
                Item.Quality-= Constants.COMMON_DECREMENT;
            }
        }

        /// <summary>
        /// Handles expired items
        /// </summary>
        protected virtual void HandleExpired()
        {
            DecrementQuality();
        }

        #endregion
    }
}
