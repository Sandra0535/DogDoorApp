using DogDoorApp.Model;

namespace DogDoorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            door.AddAllowedBark(new Bark("rowlf"));
            door.AddAllowedBark(new Bark("rooowlf"));
            door.AddAllowedBark(new Bark("rawlf"));
            door.AddAllowedBark(new Bark("woof"));
            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);

            Console.WriteLine("Bruce starts barking.");
            recognizer.Recognize(new Bark("rowlf"));

            Console.WriteLine("\nBruce has gone outside");
            try
            {
                Thread.Sleep(10000); // Sleep for 10 seconds (10000 milliseconds)
            }
            catch (ThreadInterruptedException)
            {
                // Handle InterruptedException if needed
            }
            Console.WriteLine("\nBruce's all done");
            Console.WriteLine("...but he's stuck outside!");

            //simulate the hardware hearing a bark(not Bruce)
            Bark smallDogBark = new Bark("yip");
            Console.WriteLine("A small dog starts barking");
            recognizer.Recognize(smallDogBark);
            try
            {
                Thread.Sleep(10000); // Sleep for 10 seconds (10000 milliseconds)
            }
            catch (ThreadInterruptedException)
            {
                // Handle InterruptedException if needed
            }

            //simulate the hardware hearing a bark again
            Console.WriteLine("Bruce starts barking");
            recognizer.Recognize(new Bark("rooowlf"));

            Console.WriteLine("\nBruce's back inside");
            door.Close();
        }
    }

}