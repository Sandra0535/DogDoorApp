using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace DogDoorApp.Model
{
    internal class Remote
    {
        private DogDoor door;
        private Timer timer;
        public Remote(DogDoor door)
        {
            this.door = door;
        }
        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (door.IsOpen())
            {
                door.Close();
            }
            else
            {
                door.Open();
            }
        }
    }
}

