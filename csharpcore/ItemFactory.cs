using System;
using System.Collections.Generic;
using csharpcore.Abstraction;
using csharpcore.Concrete;

namespace csharpcore
{
    /// <summary>
    /// Factory of items
    /// </summary>
    public sealed class ItemFactory
    {
        #region Fileds
        private static readonly  Lazy<ItemFactory> Lazy= new Lazy<ItemFactory>(()=>new ItemFactory());
        private static readonly Dictionary<string, BaseItem> ItemsTypes = new Dictionary<string, BaseItem>();
        private const string CHEESE = "Aged Brie";
        private const string SULFURA = "Sulfuras, Hand of Ragnaros";
        private const string CONCERT = "Backstage passes to a TAFKAL80ETC concert";
        private const string CONJURED = "Conjured";
        private const string DEFAULT= "Default";
        #endregion

        private ItemFactory()
        {
            ItemsTypes.Add(SULFURA, new LegendaryItem());
            ItemsTypes.Add(CHEESE,new CheeseItem());
            ItemsTypes.Add(CONCERT, new ConcertItem());
            ItemsTypes.Add(CONJURED, new ConjuredItem());
            ItemsTypes.Add(DEFAULT, new CommonItem());
        }
        public static ItemFactory Instance => Lazy.Value;

        public BaseItem CreateItem(Item item)
        {
            var resolvedItem = ItemsTypes.TryGetValue(item.Name, out var baseItem)
                ? baseItem
                : new CommonItem();
            resolvedItem.Item = item;

            return resolvedItem;
        }
    }
}
