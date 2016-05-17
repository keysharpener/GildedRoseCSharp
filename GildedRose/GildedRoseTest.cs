using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRose
{
    [TestFixture()]
    public class GildedRoseTest
    {
        [TestCase("toto", 0, 1, 0)]
        [TestCase("Sulfuras, Hand of Ragnaros", 0, 1, 1)]
        [TestCase("Aged Brie", 0, 1, 3)]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 3, 5, 8)]
        public void Should_correctly_handle_items_through_first_block(string itemName, int itemSellIn, int itemQuality,
            int expectedQuality)
        {
            var itemToTest = new Item {Name = itemName, SellIn = itemSellIn, Quality = itemQuality};

            IList<Item> Items = new List<Item>
            {
                itemToTest
            };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(expectedQuality, itemToTest.Quality);
        }

      
    }
}

