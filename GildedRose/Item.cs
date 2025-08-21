namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void UpdateQuality()
    {
        switch (Name)
        {
            case "Aged Brie":
                UpdateAgedBrieQuality();
                break;
            case "Backstage passes to a TAFKAL80ETC concert":
                UpdateBackstagePassQuality();
                break;
            case { } s when s.StartsWith("Conjured"):
                UpdateConjuredItemQuality();
                break;
            case "Sulfuras, Hand of Ragnaros":
                return;
            default: UpdateNormalItemQuality();
                break;
        }
        return;

        void UpdateAgedBrieQuality()
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

        void UpdateBackstagePassQuality()
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

        void UpdateConjuredItemQuality()
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

        void UpdateNormalItemQuality()
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