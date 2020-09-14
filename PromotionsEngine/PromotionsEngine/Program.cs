using System;
using System.Collections.Generic;
using PromotionsEngine.Utilities;
using PromotionsEngine.Models;

namespace PromotionsEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> skuPriceDictionary = new Dictionary<string, int>() { { "A", 50 }, { "B", 30 }, { "C", 20 }, { "D", 15 } };

            List<string> skuIds = new List<string>() { "A", "B", "C", "D", "A", "A", "A", "A", "B", "B", "B", "C", "C", "C", "A", "D", "D", "C", "C", "B", "B" };

            Dictionary<string, int> skuDictionary = SkuUtilities.CreateSkuDictionary(skuIds);

            Cart cart = SkuUtilities.GetCart(skuDictionary, skuPriceDictionary);
            cart.CalculateCartAmount();
        }
    }
}
