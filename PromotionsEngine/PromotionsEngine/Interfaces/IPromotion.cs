using System;
using System.Collections.Generic;
using System.Text;
using PromotionsEngine.Models;

namespace PromotionsEngine.Interfaces
{
    interface IPromotion
    {
        void ApplyPromotion(Cart cart);
    }
}
