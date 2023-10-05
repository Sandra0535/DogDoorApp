using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp.Model
{
    internal class BarkRecognizer
    {
        private DogDoor door;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }
        public void Recognize(Bark bark)
        {
            Console.WriteLine("BarkRecognizer: Hears a '"+bark.GetSound()+"'");
            foreach (Bark allowedBark in door.allowedBarks)
            {
                if (allowedBark.Equals(bark))
                {
                    door.Open();
                    return;
                }
            }
        }
    }
}
