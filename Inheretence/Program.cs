using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheretence.Model;

namespace Inheretence
{
    class Program
    {
        static void Main(string[] args)
        {

            Functionality functionality = new Functionality();

            Flash flash = new Flash();

            flash.Name = "JetFlash 880S";
            flash.Capacity = 64;
            flash.SpeedOfRecording = 625;

            functionality.listFlashes.Add(flash);

            Flash flash2 = new Flash();
            flash2.Name = "JetFlash 990A";
            flash2.Capacity = 128;
            flash2.SpeedOfRecording = 1125;

            functionality.listFlashes.Add(flash2);

            functionality.GetTimeCopy(functionality.listFlashes, 400, true);

            functionality.DeviceQuantity(TypeDevice.Flash, 400);
            
            functionality.CopyData(functionality.listFlashes, 400);
        }
    }
}
