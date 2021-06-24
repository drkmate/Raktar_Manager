using System;
using System.Collections.Generic;
using System.Text;

namespace PRogtech_Raktar
{
    class WarehouseIsFullException:Exception
    {
        public WarehouseIsFullException():base("A raktárban nincs több hely!")
        {
               
        }
    }
}
