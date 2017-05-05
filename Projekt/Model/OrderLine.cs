using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportDatabase.Model
{
    class OrderLine
    {
        public int OrderLineNr { get; set; }

        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Amount { get; set; }
        public DateTime DateTime { get; set; }

    }
}
