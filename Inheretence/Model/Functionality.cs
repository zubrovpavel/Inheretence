using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheretence.Model
{
    public enum TypeDevice
    {
        Flash,
        DVD,
        HDD
    }
    public class Functionality
    {
        private double sumCap = 0;
        private double time = 0;
        public List<HDD> ListHDD;
        public List<DVD> ListDVD;
        public List<Flash> listFlashes;

        public Functionality()
        {
            ListHDD = new List<HDD>();
            ListDVD = new List<DVD>();
            listFlashes = new List<Flash>();
        }



        //●	расчет общего количества памяти всех устройств;
        public double CalculationCapAllDevice()
        {
            sumCap = ListHDD.Sum(item => double.Parse(item.Capacity.ToString()));
            sumCap += ListDVD.Sum(item => double.Parse(item.Capacity.ToString()));
            sumCap += listFlashes.Sum(item => double.Parse(item.Capacity.ToString()));

            return sumCap;
        }

        /// <summary>
        /// копирование информации на устройства;
        /// </summary>
        /// <param name="aFlashes">Список флэшек</param>
        /// <param name="capacity">Объем инфорации</param>
        public void CopyData(List<Flash> aFlashes, double capacity)
        {
            time = GetTimeCopy(aFlashes, capacity)*100;

            DateTime finalTime = DateTime.Now.AddMinutes(time);
            while (DateTime.Now != finalTime)
            {
                Thread.Sleep(Int32.Parse(Math.Round(time*100).ToString()));
                Console.Write(".");
            }
        }

        /// <summary>
        /// копирование информации на устройства
        /// </summary>
        /// <param name="aHdds">Список HDD устройств</param>
        public void CopyData(List<HDD> aHdds)
        {
           
        }

        public void CopyData(List<DVD> aDvds)
        {

        }

        /// <summary>
        /// расчет времени необходимого для копирования;
        /// </summary>
        /// <param name="aFlashes">Список флешек</param>
        /// <param name="capacity">Объем инфы</param>
        /// <param name="needShow">Надобность отображения</param>
        /// <returns></returns>
        public double GetTimeCopy(List<Flash> aFlashes, double capacity, bool needShow = false)
        {
            sumCap = aFlashes.Sum(item => double.Parse(item.Capacity.ToString()));
            time = 0;
            foreach (Flash item in aFlashes)
            {
                time += item.Capacity / item.SpeedOfRecording;
            }

            if (needShow == true)
            {
                Console.WriteLine("Для копирования {0} необходимо {1} времени", capacity, time);
            }

            return time;
        }

        /// <summary>
        /// расчет необходимого количества носителей информации представленных типов для переноса информации.
        /// </summary>
        /// <param name="tdDevice">Тип устройства</param>
        /// <param name="capacity">Объем информации</param>
        public void DeviceQuantity(TypeDevice tdDevice, double capacity)
        {
            int count = 0;

            switch (tdDevice)
            {
                case TypeDevice.DVD:
                    {
                        foreach (DVD item in ListDVD)
                        {
                            count = Int32.Parse((capacity / item.Capacity).ToString());
                            Console.WriteLine("Вам понадобится дисков типа {0} - {1} штук", item.DeviceType, count);
                        }
                    }
                    break;
                case TypeDevice.Flash:
                    {
                        foreach (Flash item in listFlashes)
                        {
                            double x = capacity/item.Capacity;
                            count = Int32.Parse(Math.Round(x).ToString());
                            Console.WriteLine("Вам понадобится {0} {1} флеш-носителей", count, item.Capacity);
                        }
                    }
                    break;
                case TypeDevice.HDD:
                    {
                        foreach (HDD item in ListHDD)
                        {
                            count = Int32.Parse((capacity / item.Capacity).ToString());
                            Console.WriteLine("Вам понадобится дисков {0} {1} жесткий диск", count, capacity);
                        }
                    }
                    break;
            }
        }

    }
}
