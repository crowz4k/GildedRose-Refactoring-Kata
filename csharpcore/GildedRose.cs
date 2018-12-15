using System.Collections.Generic;

namespace csharpcore
{
    /// <summary>
    /// Main entry point for application.
    /// </summary>
    public class GildedRose
    {
        private readonly IList<Item> _items;
        public GildedRose(IList<Item> items)
        {
            this._items = items;
        }

        /// <summary>
        /// Handler for updating inventory
        /// </summary>
        /// <param name="add"></param>
        //TODO: This is called UpdateQuality, and in the official rules we are not allowed to change this 
        //TODO: 2 things are not allowed Item class, and Method UpdateQuality even if the name is not right.
        public void UpdateQuality()
        {
            foreach (var element in _items)
            {
                ItemFactory.Instance.CreateItem(element).UpdateItem();
            }
        }

    }
}
