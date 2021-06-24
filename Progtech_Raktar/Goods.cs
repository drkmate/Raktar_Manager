using System;
using System.Collections.Generic;
using System.Text;

namespace PRogtech_Raktar
{
    public class Goods
    {
        private static int nextId = 0;
        private string name;
        private int price;
        private string description;
        private int warehouseId;

        public string Name { get { return name; } set { this.name = value; } }
        public int Price { get { return price; } set { this.price = value; } }
        public string Description { get { return description; } set { this.description = value; } }
        private int id;
        public int Id { get { return id; } }

        public Goods(string name, int price, string description, int warehouseId)
        {
            nextId++;
            this.id = nextId;
            Name = name;
            Price = price;
            Description = description;
            WarehouseId = warehouseId;
        }
        public int WarehouseId
        {
            get
            {
                return warehouseId;
            }
            set
            {
                this.warehouseId = value;
            }
        }

    }
}
