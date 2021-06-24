using System;
using System.Collections.Generic;
using System.Text;

namespace PRogtech_Raktar
{
    public class ShoppingCart
    {
        public static ShoppingCart Factory() {
            return new ShoppingCart();
        }
        public List<Goods> goods;

        private ShoppingCart()
        {
            goods = new List<Goods>();
        }

    }
}
