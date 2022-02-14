using demoConsole.Interface;
using demoConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoConsole
{
    internal class VehicalFactory<T> where T : class, new()
    {
        public T GetVehical()
        {
            return new T();
        }
    }

    //public class FactoryPattern<K, T>
    //    where T : class, K, new()
    //{
    //    public static K CreateInstance()
    //    {
    //        K objK;

    //        objK = new T();

    //        return objK;
    //    }
    //}
}
