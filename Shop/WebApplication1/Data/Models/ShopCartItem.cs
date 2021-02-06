using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    public class ShopCartItem
    {

        public int id { get; set; }
        public Car car { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string shopCartId { get; set; }
    }
}
