using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRose
{
	[TestFixture()]
	public class GildedRoseTest
	{
		[TestCase("toto", 0, 1, 0)]
	    public void Should_remove_quality(string itemName, int itemSellIn, int itemQuality, int expectedQuality)
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

