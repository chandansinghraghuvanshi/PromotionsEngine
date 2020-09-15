using System;
using System.Collections.Generic;
using System.Text;
using PromotionsEngine.Interfaces;
using PromotionsEngine.Models;

namespace PromotionsEngine.Implementations
{
    class CombinationalPromotion : Promotion, IPromotion
    {
        public CombinationalPromotion()
        {
            this.PromotionType = "Combinational";
        }

        public override void ApplyPromotion(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
