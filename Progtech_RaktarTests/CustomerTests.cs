using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRogtech_Raktar;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRogtech_Raktar.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        Goods g1 = new Goods("kenyér", 300, "valamik", 1);
        Goods g2 = new Goods("kenyér2", 350, "valamik", 1);
        Goods g3 = new Goods("kenyér3", 4000, "valamik", 1);
        List<Goods> goodsList = new List<Goods>();
        List<Warehouse> warehouses = new List<Warehouse>();
        
        [TestMethod()]
        public void DeleteFromCartTest()
        {
            Customer customer1 = new Customer(2000);
            customer1.AddToCart(g1);
            customer1.AddToCart(g2);

            customer1.DeleteFromCart(g2);
        }

        [TestMethod()]
        public void BuyTest()
        {
            
            Customer customer1 = new Customer(650);
            goodsList.Add(g1);
            goodsList.Add(g2);
            goodsList.Add(g3);
            Warehouse wh1 = new Warehouse(2000, goodsList);
            warehouses.Add(wh1);
            customer1.AddToCart(g1);
            customer1.AddToCart(g2);
            Console.WriteLine(g1.Price);
            Console.WriteLine( g2.Price);
            Console.WriteLine(customer1.Cash);
            customer1.Buy(warehouses);
        }
    }
}