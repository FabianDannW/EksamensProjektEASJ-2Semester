using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportDatabase.Model
{
    class ProductPart
    {
        public int ProductNr { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public double PricePrUnitEuro { get; set; }
        public double PriceprUnitDKK { get; set; }
        public double PriceTotalEuro { get; set; }
        public double PriceTotalDKK { get; set; }

    }
}
