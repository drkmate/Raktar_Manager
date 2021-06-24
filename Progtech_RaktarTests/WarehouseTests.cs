using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRogtech_Raktar;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRogtech_Raktar.Tests
{
    [TestClass()]
    public class WarehouseTests
    {
        Goods g1 = new Goods("kenyér", 300, "valamik", 1);
        Goods g2 = new Goods("kenyér", 300, "valamik", 1);
        List<Goods> goodsList = new List<Goods>();
        List<Warehouse> warehouses = new List<Warehouse>();
        List<Goods> cargo = new List<Goods>();

        [TestMethod()]
        public void AddTest()
        {
            Warehouse wh1 = new Warehouse(1, goodsList);
            wh1.Add(g1);
            wh1.Add(g2);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Warehouse wh1 = new Warehouse(1, goodsList);
            wh1.Add(g1);
            wh1.Delete(g1);
        }

        [TestMethod()]
        public void SoldTest()
        {
            Warehouse wh1 = new Warehouse(1, goodsList);
            wh1.Add(g1);
            wh1.Sold(g1);
        }

        [TestMethod()]
        public void SupplyTest()
        {
            Warehouse wh1 = new Warehouse(100, goodsList);
            cargo.Add(g1);
            cargo.Add(g2);
            wh1.Supply(cargo);
        }
    }
}