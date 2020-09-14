using System;
using System.Collections.Generic;
using System.Text;
using PromotionsEngine.Models;

namespace PromotionsEngine.Utilities
{
    class SkuUtilities
    {
        public static Dictionary<string, int> CreateSkuDictionary(List<string> skuIds)
        {
            int skuCounter = 0;
            string skuId = "";
            List<StockKeepingUnit> stockKeepingUnits = new List<StockKeepingUnit>();
            Dictionary<string, int> skuDictionary = new Dictionary<string, int>();

            for (int count = 0; count < skuIds.Count; count++)
            {
                skuId = skuIds[count];

                if (!skuDictionary.ContainsKey(skuIds[count]))
                {
                    skuDictionary.Add(skuId, 1);
                }
                else
                {
                    skuCounter = skuDictionary[skuId];
                    skuCounter++;
                    skuDictionary[skuId] = skuCounter;
                }
            }

            return skuDictionary;
        }

        public static Cart GetCart(Dictionary<string, int> skuDictionary)
        {
            Cart cart = new Cart();

            foreach (KeyValuePair<string, int> keyValuePair in skuDictionary)
            {
                StockKeepingUnit stockKeepingUnit = new StockKeepingUnit();
                stockKeepingUnit.ID = keyValuePair.Key;
                stockKeepingUnit.Units = keyValuePair.Value;

                cart.StockKeepingUnits.Add(stockKeepingUnit);
            }

            return cart;
        }
    }
}
