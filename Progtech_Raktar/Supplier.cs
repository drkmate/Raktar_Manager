using System;
using System.Collections.Generic;
using System.Text;

namespace PRogtech_Raktar
{
    public class Supplier
    {
        private int id;
        private static int nextId = 0;
        private int warehouseId;
        public List<Goods> cargo;

        public int Id
        {
            get
            {
                return id;
            }
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

        public Supplier(int warehouseId, List<Goods> cargo)
        {
            nextId++;
            this.id = nextId;
            WarehouseId = warehouseId;
            this.cargo = new List<Goods>(cargo);
        }
    }
}
