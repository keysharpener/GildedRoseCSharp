using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRose
{
	[TestFixture()]
	public class GildedRoseTest
	{
		[Test()]
		public void foo() {
			IList<Item> Items = new List<Item> { new Item{Name = "foo", SellIn = 0, Quality = 0} };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual("fixme", Items[0].Name);
		}
	}
}

