using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.P01_SalesDatabase.Models
{
    internal class Sale
    {
        public int SaleId { get; set; }
        public int? Date { get; set; } 
        public Customer customer { get; set; }
        public int CustomerId { get; set; }

        public Product product { get; set; }
        public int ProductId { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }

    }
}
