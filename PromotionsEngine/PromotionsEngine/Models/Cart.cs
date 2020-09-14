using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionsEngine.Models
{
    class Cart
    {
        private List<StockKeepingUnit> stockKeepingUnits = new List<StockKeepingUnit>();

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
    }
}
