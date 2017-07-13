using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePolymorphism
{
    class Dishwasher : Appliances
    {
        public override void Clean()
        {
            Console.WriteLine("Im clean now");
        }
    }
}
