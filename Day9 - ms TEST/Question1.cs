using System;
using System.Collections.Generic;
using System.Linq;

public class PurchaseList
{
    public static void Run()
    {
        string input = Console.ReadLine();
        List<int> prices = input.Split().Select(int.Parse).ToList();

        int soldOnce = GetPriceSoldOnce(prices);
        int soldMoreThanOnce = GetPriceSoldMoreThanOnce(prices);

        Console.WriteLine(soldOnce != -1 ? soldOnce.ToString() : "none");
        Console.WriteLine(soldMoreThanOnce != -1 ? soldMoreThanOnce.ToString() : "none");
    }

    public static int GetPriceSoldOnce(List<int> prices)
    {
        int priceSoldOnce = -1;
        Dictionary<int, int> priceCount = new Dictionary<int, int>();

        foreach (int price in prices)
        {
            if (priceCount.ContainsKey(price))
            {
                priceCount[price]++;
            }
            else
            {
                priceCount[price] = 1;
            }
        }

        foreach (int price in prices)
        {
            if (priceCount[price] == 1)
            {
                priceSoldOnce = price;
                break;
            }
        }

        return priceSoldOnce;
    }

    public static int GetPriceSoldMoreThanOnce(List<int> prices)
    {
        int priceSoldMoreThanOnce = -1;
        Dictionary<int, int> priceCount = new Dictionary<int, int>();

        foreach (int price in prices)
        {
            if (priceCount.ContainsKey(price))
            {
                priceCount[price]++;
            }
            else
            {
                priceCount[price] = 1;
            }
        }

        foreach (int price in prices)
        {
            if (priceCount[price] > 1)
            {
                priceSoldMoreThanOnce = price;
                break;
            }
        }

        return priceSoldMoreThanOnce;
    }
}
