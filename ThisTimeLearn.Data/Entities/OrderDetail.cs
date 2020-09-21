using System.Collections.Generic;
using ThisTimeLearn.Data.Entities;

namespace ThisTimeLearn.Data.EF
{
    public class OrderDetail
    {
        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        public Order Order { get; set; }

        public Product Product { get; set; }
       
    }
}