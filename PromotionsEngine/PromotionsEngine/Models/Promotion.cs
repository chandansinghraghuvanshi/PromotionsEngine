using System;
using System.Collections.Generic;
using System.Text;
using PromotionsEngine.Interfaces;

namespace PromotionsEngine.Models
{
    abstract class Promotion : IPromotion
    {
        protected string skuRequired;
        protected int numberOfSkuRequired;
        protected int promotionalPrice;
        protected string promotionType;

        public string PromotionType
        {
            get
            {
                return promotionType;
            }
            set
            {
                promotionType = value;
            }
        }

        public string SkuRequired
        {
            get
            {
                return skuRequired;
            }
            set
            {
                skuRequired = value;
            }
        }

        public int NumberOfSkuRequired
        {
            get
            {
                return numberOfSkuRequired;
            }
            set
            {
                numberOfSkuRequired = value;
            }
        }

        public int PromotionalPrice
        {
            get
            {
                return promotionalPrice;
            }
            set
            {
                promotionalPrice = value;
            }
        }

        public abstract void ApplyPromotion(Cart cart);
    }
}
