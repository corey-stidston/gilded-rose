using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    public readonly IList<Item> Items;

    public GildedRose(IList<Item> items)
    {
        this.Items = items;
    }

    public void UpdateQuality()
    {
        foreach(var item in Items)
        {
            item.UpdateQuality();
        }
    }
}