using demoConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoConsole
{
     class Outer
    {

        public void Action(int id)
        { 
            Dictionary<int, Type> keyValuePairs = new Dictionary<int, Type>();
            keyValuePairs.Add(1, typeof(demoConsole.Models.Bus));
            keyValuePairs.Add(2, typeof(demoConsole.Models.Car));
            var ty = keyValuePairs[1];


            var vf = new VehicalFactory(ty);
            //var car = Convert.ChangeType(vf.GetVehical(), ty);
            var car = ConvertObject<Vehical>(vf);
            var owner = car.GetOwner();
        }

        public T ConvertObject<T>(object input)
        {
            return (T)Convert.ChangeType(input, typeof(T));
        }
    }

    internal class VehicalFactory
    {
        private Type ty;
        object myObject = null;

        public VehicalFactory(Type ty)
        {
            Type type = ty.MakeGenericType();
            object myObject = Activator.CreateInstance(type);
        }

        internal object GetVehical()
        {
            return myObject;
        }
    }
}
