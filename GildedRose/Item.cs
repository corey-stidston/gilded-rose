namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void UpdateQuality()
    {
        if (Name != "Aged Brie" && Name != "Backstage passes to a TAFKAL80ETC concert")
        {
            if (Quality > 0)
            {
                if (Name != "Sulfuras, Hand of Ragnaros")
                {
                    --Quality;
                }
            }
        }
        else
        {
            if (Quality < 50)
            {
                Quality = Quality + 1;

                if (Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (SellIn < 11)
                    {
                        if (Quality < 50)
                        {
                            ++Quality;
                        }
                    }

                    if (SellIn < 6)
                    {
                        if (Quality < 50)
                        {
                            ++Quality;
                        }
                    }
                }
            }
        }

        if (Name != "Sulfuras, Hand of Ragnaros")
        {
            --SellIn;
        }

        if (SellIn < 0)
        {
            if (Name != "Aged Brie")
            {
                if (Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Quality > 0)
                    {
                        if (Name != "Sulfuras, Hand of Ragnaros")
                        {
                            --Quality;
                        }
                    }
                }
                else
                {
                    Quality = 0;
                }
            }
            else
            {
                if (Quality < 50)
                {
                    ++Quality;
                }
            }
        }
    }

}