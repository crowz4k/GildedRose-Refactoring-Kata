using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpcore.TestFixture
{
    public class GildedRoseFixture
    {
        public GildedRoseFixture()
        {
            Items = new List<Item>();
            Application = new GildedRose(Items);
        }

        private IList<Item> Items { get; set; }
        public GildedRose Application { get; }

        public void AddItem(Item item)
        {
            Items.Clear();
            Items.Add(item);
        }

        public Item RetrieveItem()
        {
            return Items.Last();
        }
    }
}
