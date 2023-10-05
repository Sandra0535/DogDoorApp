using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp.Model
{
    internal class Bark
    {
        private string Sound;
        public Bark(string sound)
        {
            Sound = sound;
        }
        public string GetSound()
        {
            return Sound;
        }
        public bool Equals(object bark)
        {
            if (bark is Bark)
            {
                Bark otherBark = (Bark)bark;
                if (Sound.Equals(otherBark.Sound, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
