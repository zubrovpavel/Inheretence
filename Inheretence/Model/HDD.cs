using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence.Model
{
    public class HDD : Storage
    {
        public InterfaceType InterfaceType { get; set; }
        public int QuantityRazdel { get; set; }
        public double RazdelCap { get; set; }

        public override void GetCap()
        {
            Console.WriteLine("Объем памяти диска: {0}", Capacity);
        }

        //public override void CopyData()
        //{
            
        //}
    }
}
