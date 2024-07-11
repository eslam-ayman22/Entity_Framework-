using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.P01_SalesDatabase.Models
{
    internal class Product
    {
        public int ProductId { get; set; }

        public string Description { get; set; }
        public  string Name { get; set; }
        

        public int Quantity { get; set; }

        public int Price { get; set; }

        public string Descripton { get; set; }



        public ICollection<Sale> sales { get; set; }
    }
}
