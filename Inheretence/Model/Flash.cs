using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence.Model
{
    public class Flash : Storage
    {
        
        public InterfaceType InterfaceType { get; set; }
        public override void GetCap()
        {
            Console.WriteLine("Объем памяти: {0}", Capacity);
        }

        public void SetPrice(double price)
        {
            Price = price;
        }

        //public override void CopyData()
        //{
        //    Console.WriteLine();
        //}

    }
}
