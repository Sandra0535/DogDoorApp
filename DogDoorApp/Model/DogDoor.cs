using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;


namespace DogDoorApp.Model
{
    internal class DogDoor
    {
        private bool open;
        private Timer timer;
        private Bark allowedBark;
        public List<Bark> allowedBarks { get; private set; } = new List<Bark>();

        public DogDoor()
        {
            open = false;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            open = true;

            timer = new Timer(5000); // 5000 milliseconds = 5 seconds
            timer.Elapsed += TimerElapsed;
            timer.AutoReset = false; // Ensures the timer only runs once
            timer.Start();
        }
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Close();
            timer.Dispose(); // Dispose of the timer to release resources
        }

        public void Close()
        {
            Console.WriteLine("The dog door closes.");
            open = false;
        }

        public bool IsOpen()
        {
            return open;
        }
        
        public void AddAllowedBark(Bark allowedBark)
        {
            this.allowedBarks.Add(allowedBark);
        }
    }
}