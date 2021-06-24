using System;
using System.Collections.Generic;
using System.Text;

namespace PRogtech_Raktar
{
    class InvalidIdException: Exception
    {
        public InvalidIdException():base("Nincs ilyen azonosító")
        {

        }

    }
}
