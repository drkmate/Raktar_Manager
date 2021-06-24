using System;
using System.Collections.Generic;
using System.Text;

namespace PRogtech_Raktar
{
    interface IWarehouse
    {
        void Add(Goods goods);
        void Delete(Goods goods);
        void Modify(int id, string name);
        void Modify(int id, string name, int price);
        void Modify(int id, string name, int price, string description);


    }
}
