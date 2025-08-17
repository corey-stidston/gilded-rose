namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void UpdateQuality()
    {
        var isAgedBrie = Name == "Aged Brie";

        if (isAgedBrie)
        {
            if (Quality < 50)
            {
                ++Quality;
            }

            --SellIn;

            if (SellIn < 0)
            {
                if (Quality < 50)
                {
                    ++Quality;
                }
            }
        }
        else
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
                if (Quality < 50)
                {
                    ++Quality;

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

        }
    }

    private void NewMethod(bool isAgedBrie)
    {
        if (!isAgedBrie && Name != "Backstage passes to a TAFKAL80ETC concert")
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
                ++Quality;

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
            if (!isAgedBrie)
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