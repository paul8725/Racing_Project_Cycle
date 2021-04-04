using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing_Project_Cycle
{
   public class better
    {
        //generate the random number 
        Random rd = new Random();
        public int rNumber() {
            return rd.Next(1, 50);
        }

    }
}
