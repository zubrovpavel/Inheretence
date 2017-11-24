using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence.Model
{
    public enum InterfaceType
    {
        Usb1,
        Usb2,
        Usb3
    }
    public abstract class Storage
    {

        public string Name { get; set; }
        public double Capacity { get; set; }
        public double FreeCapacity { get; set; }
        public double SpeedOfRecording { get; set; }
        public double Price { get; protected set; }


        //●	получение объема памяти
        public abstract void GetCap();

        //●	копирование данных (файлов/папок) на устройство
        //public abstract void CopyData();

        //●	получение информации о свободном объеме памяти на устройстве;
        public virtual void GetInfoFreeCapacity()
        {
            Console.WriteLine("Доступно памяти: {0}", FreeCapacity);
        }

        //●	получение общей/полной информации об устройстве.
        public virtual void GetInfo()
        {
            Console.WriteLine("Наименование носителя: {0};", Name);
            Console.WriteLine("Объем: {0}", Capacity);
            Console.WriteLine("Скорость записи: {0}", SpeedOfRecording);
        }
    }
}
