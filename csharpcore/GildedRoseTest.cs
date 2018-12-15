using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csharpcore.Abstraction;
using csharpcore.Concrete;
using csharpcore.TestFixture;
using FakeItEasy;
using FluentAssertions;

namespace csharpcore
{
    public class GildedRoseTest:IClassFixture<GildedRoseFixture>
    {
        private readonly GildedRoseFixture _fixture;

        public GildedRoseTest(GildedRoseFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public  void Process_Common_Item()
        {
            // ARRANGE 
            Item item = new Item
            {
                Name = "Some common items",
                Quality = 3,
                SellIn = 1
            };
            _fixture.AddItem(item);

            // ACT
            _fixture.Application.UpdateQuality();

            // ASSERT
            _fixture.RetrieveItem().Quality.Should().Be(2);
            _fixture.RetrieveItem().SellIn.Should().Be(0);
        }

        [Fact]
        public void Process_Legendary_Item()
        {
            // ARRANGE 
            Item item = new Item
            {
                Name = "Sulfuras, Hand of Ragnaros",
                Quality = 80,
                SellIn = 1
            };
            _fixture.AddItem(item);

            // ACT
            _fixture.Application.UpdateQuality();

            // ASSERT
            _fixture.RetrieveItem().Quality.Should().Be(80);
            _fixture.RetrieveItem().SellIn.Should().Be(1);
        }

        [Fact]
        public void Process_Cheese_Item()
        {
            // ARRANGE 
            Item item = new Item
            {
                Name = "Aged Brie",
                Quality = 4,
                SellIn = 1
            };
            _fixture.AddItem(item);

            // ACT
            _fixture.Application.UpdateQuality();

            // ASSERT
            _fixture.RetrieveItem().Quality.Should().Be(5);
            _fixture.RetrieveItem().SellIn.Should().Be(0);
        }
        
        [Fact]
        public void Process_Concert_Item()
        {
            // ARRANGE 
            Item item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 3,
                SellIn = 1
            };
            _fixture.AddItem(item);

            // ACT
            _fixture.Application.UpdateQuality();

            // ASSERT
            _fixture.RetrieveItem().Quality.Should().Be(6);
            _fixture.RetrieveItem().SellIn.Should().Be(0);
        }
    }
}
