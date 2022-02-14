using demoConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoConsole.Models
{
    internal class Bus:Vehical
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }

        public string GetOwner()
        {
            return OwnerName;
        }
    }
}
