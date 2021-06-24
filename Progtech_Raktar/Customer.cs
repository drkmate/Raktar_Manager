using System;
using System.Collections.Generic;
using System.Text;

namespace PRogtech_Raktar
{
    public class Customer
    {
        private int id;
        private static int nextId = 0;
        private int cash;
        public ShoppingCart cart = ShoppingCart.Factory();


        public int Id
        {
            get
            {
                return id;
            }
        }

        public int Cash
        {
            get
            {
                return cash;
            }
            set
            {
                if (value < 0)
                    throw new CantBeNegativeException();
                this.cash = value;
            }
        }
        public void AddToCart(Goods g)
        {
            cart.goods.Add(g);
        }
        public void DeleteFromCart(Goods g)
        {
            if (!cart.goods.Contains(g))
            {
                throw new GoodsNotInCartException();
            }
            cart.goods.Remove(g);
        }
        public int FinalPrice()
        {
            int sum = 0;
            if (cart.goods.Count > 0)
            {
                for (int i = 0; i < cart.goods.Count; i++)
                {
                    sum += cart.goods[i].Price;

                }
                return sum;
            }
            return 0;
        }

        public void Buy(List<Warehouse> whouses)
        {
            if (FinalPrice() > cash)
            {
                throw new NotEnoughMoneyException();
            }
            else
            {
                cash -= FinalPrice();
                for (int i = 0; i < cart.goods.Count; i++)
                {
                    for (int z = 0; z < whouses.Count; z++)
                    {
                        if (cart.goods[i].WarehouseId == whouses[z].Id)
                        {
                            whouses[z].Sold(cart.goods[i]);
                        }
                    }
                }
            }
        }

        public Customer(int cash)
        {
            nextId++;
            this.id = nextId;
            Cash = cash;
        }
    }
}
