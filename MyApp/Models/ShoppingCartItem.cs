using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public int Amount { get; set; }
        public drinks drink { get; set; }
        public string shoppingcartid { get; set; }

    }
}
