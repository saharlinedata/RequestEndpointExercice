using System;
using System.Collections.Generic;
using System.Text;

namespace RequestEndpointExercice
{
   public class CreateOrderMsg
   {
        Guid id;
        string msg = "cmdMsg";

        public string GetMsg()
        {
            return msg;
        }
    }
}
