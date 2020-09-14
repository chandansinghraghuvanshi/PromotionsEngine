using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionsEngine.Models
{
    class StockKeepingUnit
    {
        private string id;
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
