using System;
using System.Collections.Generic;
using System.Text;
using PromotionsEngine.Interfaces;

namespace PromotionsEngine.Models
{
    class Cart
    {
        private int totalAmount = 0;
        private List<StockKeepingUnit> stockKeepingUnits = new List<StockKeepingUnit>();
        private IPromotion promotion;

        public int TotalAmount
        {
            get
            {
                return totalAmount;
            }
            set
            {
                totalAmount = value;
            }
        }

        public List<StockKeepingUnit> StockKeepingUnits
        {
            get
            {
                return stockKeepingUnits;
            }
            set
            {
                stockKeepingUnits = value;
            }
        }

        public void CalculateCartAmount()
        {
            totalAmount = 0;

            foreach (StockKeepingUnit stockKeepingUnit in this.stockKeepingUnits)
            {
                totalAmount += (stockKeepingUnit.Units * stockKeepingUnit.UnitPrice);
            }
        }

        public void ApplyPromotion(IPromotion promotion)
        {
            this.promotion = promotion;
            promotion.ApplyPromotion(this);
        }
    }
}
