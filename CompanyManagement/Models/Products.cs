using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyManagement.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public string Brand { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal SalePrice { get; set; }
    }
}
