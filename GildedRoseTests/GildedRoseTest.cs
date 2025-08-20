using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void ConjuredItemDegradesTwiceAsFast()
    {
        IList<Item> items = new List<Item>
        {
            new Item { Name = "Conjured", SellIn = 10, Quality = 50 },
            new Item { Name = "Conjured", SellIn = -1, Quality = 10 } // Past sell by date
        };
        
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        
        Assert.Equal("Conjured", items[0].Name);
        Assert.Equal(9, items[0].SellIn);
        Assert.Equal(48, items[0].Quality);
        
        // Past sell by date
        Assert.Equal("Conjured", items[1].Name);
        Assert.Equal(-2, items[1].SellIn);
        Assert.Equal(6, items[1].Quality);
    }
}