using System;
using System.Collections.Generic;
using System.Text;
using PromotionsEngine.Interfaces;
using PromotionsEngine.Models;

namespace PromotionsEngine.Implementations
{
    class SingularPromotion : Promotion, IPromotion
    {
        public SingularPromotion()
        {
            this.PromotionType = "Singular";
        }

        public SingularPromotion(string skuRequired, int numberOfSkuRequired, int promotionalPrice)
        {
            this.skuRequired = skuRequired;
            this.numberOfSkuRequired = numberOfSkuRequired;
            this.promotionalPrice = promotionalPrice;
        }

        public override void ApplyPromotion(Cart cart)
        {
            int discount = 0;

            foreach (StockKeepingUnit sku in cart.StockKeepingUnits)
            {
                if (sku.ID == this.SkuRequired)
                {
                    if (sku.Units > this.NumberOfSkuRequired)
                    {
                        if (sku.Units % this.numberOfSkuRequired == 0)
                        {
                            discount = (sku.Units / this.NumberOfSkuRequired) * promotionalPrice;
                        }
                        else
                        {
                            discount = ((sku.Units / this.NumberOfSkuRequired) * promotionalPrice) + ((sku.Units % this.NumberOfSkuRequired) * sku.UnitPrice);
                        }
                    }
                    else if (sku.Units == this.NumberOfSkuRequired)
                    {
                        discount = this.PromotionalPrice;
                    }

                    cart.TotalAmount -= discount;
                    break;
                }
            }
        }
    }
}
