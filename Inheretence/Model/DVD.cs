using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence.Model
{
    public enum DeviceType
    {
        OneSide = 4800,
        TwoSide = OneSide * 2
    }
    public class DVD : Storage
    {
        public DVD(DeviceType t)
        {
            DeviceType = t;

            switch (t)
            {
                case DeviceType.OneSide:
                    {
                        Capacity = (double)t;
                    }
                    break;
                case DeviceType.TwoSide:
                    {
                        Capacity = (double)t;
                    }
                    break;
                default:
                    {
                        Capacity = 0;
                    }
                    break;
            }

        }

        public double SpeedOfReading { get; set; }
        public DeviceType DeviceType { get; set; }

        public override void GetCap()
        {
            Console.WriteLine("Объем памяти для типа {0}: {1}", DeviceType.ToString(), Capacity);

        }
        //public override void CopyData()
        //{
            
        //}
    }
}
