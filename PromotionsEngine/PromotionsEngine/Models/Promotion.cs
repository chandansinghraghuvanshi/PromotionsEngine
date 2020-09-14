using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionsEngine.Models
{
    class Promotion
    {
        private string skuRequired;
        private int numberOfSkuRequired;

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
    }
}
