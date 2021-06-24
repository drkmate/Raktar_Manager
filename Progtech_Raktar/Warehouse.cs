using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PRogtech_Raktar
{
    public class Warehouse : IWarehouse
    {
        private int id;
        private static int nextId = 0;
        private int capacity;
        public List<Goods> goodsList;
        public int Id
        {
            get
            {
                return id;  
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value<0)
                {
                    throw new CantBeNegativeException();
                }
                this.capacity = value;
            }
        }
        public Warehouse(int capacity, List<Goods> tmp)
        {
            nextId++;
            this.id = nextId;
            Capacity = capacity;
            this.goodsList = new List<Goods>(tmp);
        }
       
        public void Add(Goods goods)
        {
            if (capacity<=goodsList.Count)
            {
                throw new WarehouseIsFullException();
            }
            goodsList.Add(goods);
        }

        public void Delete(Goods goods)
        {
            if (!goodsList.Contains(goods))
            {
                throw new ThereIsNoGoodsException();
            }
            goodsList.Remove(goods);
        }

        public void Modify(int id, string name)
        {
            Goods tmp = null;
            for (int i = 0; i < goodsList.Count; i++)
            {
                if (goodsList[i].Id == id)
                {
                    tmp = goodsList[i];
                    goodsList[i].Name = name;
                }
            }
            if (tmp == null)
            {
                throw new InvalidIdException();
            }
        }

        public void Modify(int id, string name, int price)
        {
            Goods tmp = null;
            for (int i = 0; i < goodsList.Count; i++)
            {
                if (goodsList[i].Id == id)
                {
                    tmp = goodsList[i];
                    goodsList[i].Name = name;
                    goodsList[i].Price = price;
                }
            }
            if (tmp == null)
            {
                throw new InvalidIdException();
            }
        }

        public void Modify(int id, string name, int price, string description)
        {
            Goods tmp = null;
            for (int i = 0; i < goodsList.Count; i++)
            {
                if (goodsList[i].Id == id)
                {
                    tmp = goodsList[i];
                    goodsList[i].Name = name;
                    goodsList[i].Price = price;
                    goodsList[i].Description = description;
                }
            }
            if (tmp == null)
            {
                throw new InvalidIdException();
            }
        }

        public void Sold(Goods goods)
        {
            if (!goodsList.Contains(goods))
            {
                throw new NotInWarehouse();
            }
            else
            {
                Delete(goods);
            }
        }
        public void Supply(List<Goods> cargo)
        {
            if (cargo.Count <= 0)
            {
                throw new EmptyCargoException();
            }
            for (int i = 0; i < cargo.Count; i++)
            {
                this.Add(cargo[i]);
            }
        }
    }
}
