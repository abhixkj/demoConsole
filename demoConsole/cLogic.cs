using demoConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoConsole
{
    public class cLogic 
    {
        public cLogic()
        {
            var vf = new VehicalFactory<Car>();
            Car car = vf.GetVehical();
            car.GetOwner();
        }
       

         
    }
}
