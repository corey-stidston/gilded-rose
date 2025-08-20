namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void UpdateQuality()
    {
        var isAgedBrie = Name == "Aged Brie";
        var isBackstagePass = Name == "Backstage passes to a TAFKAL80ETC concert";
        var isSulfuras = Name == "Sulfuras, Hand of Ragnaros";
        var isConjured = Name.StartsWith("Conjured");

        if (isSulfuras) return;

        if (isAgedBrie)
        {
            if (Quality < 50)
            {
                ++Quality;
            }

            --SellIn;

            if (SellIn < 0 && Quality < 50)
            {
                ++Quality;
            }
        }
        else if (isBackstagePass)
        {
            if (Quality < 50)
            {
                ++Quality;

                if (SellIn < 11 && Quality < 50)
                {
                    ++Quality;
                }

                if (SellIn < 6 && Quality < 50)
                {
                    ++Quality;
                }
            }

            --SellIn;

            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
        else if (isConjured)
        {
            if (Quality > 0)
            {
                Quality -= 2;
            }

            --SellIn;

            if (SellIn < 0 && Quality > 0)
            {
                Quality -=2;
            }
        }
        else
        {
            if (Quality > 0)
            {
                --Quality;
            }

            --SellIn;

            if (SellIn < 0 && Quality > 0)
            {
                --Quality;
            }
        }
    }
}