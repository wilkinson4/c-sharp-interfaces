using System;

namespace ClassyElectronics
{
    public class Turntable : ITurnTable
    {
        public double CurrentSpeed { get; set; }
        public bool IsPlaying { get; set; }

        public void Play()
        {
            IsPlaying = true;
            Console.WriteLine($"Playing at {CurrentSpeed}");
        }

        public void Stop()
        {
            IsPlaying = false;
        }
    }
}