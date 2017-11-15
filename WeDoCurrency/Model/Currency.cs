using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeDoCurrency.Model
{
    public class Currency
    {
        public string @base { get; set; }
        public DateTime date { get; set; }
        public Rates rates { get; set; }
    }
}
