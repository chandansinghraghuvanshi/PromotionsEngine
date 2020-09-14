using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionsEngine.Models
{
    class StockKeepingUnit
    {
        private string id;
        private int unitPrice;
        private int units;
        
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        }

        public int Units
        {
            get
            {
                return units;
            }
            set
            {
                units = value;
            }
        }
    }
}
