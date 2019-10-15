namespace ClassyElectronics
{
    public class Speakinator3001 : ITurnTable, ISpeaker
    {
        public double CurrentSpeed { get; set; }
        public bool IsPlaying { get; set; }
        public int Volume { get; set; }

        public void Play()
        {
            IsPlaying = true;
        }

        public void Stop()
        {
            IsPlaying = false;
        }

        public void VolumeDown()
        {
            Volume--;
        }

        public void VolumeUp()
        {
            Volume++;
        }
    }
}