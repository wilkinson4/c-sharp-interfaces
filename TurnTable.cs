namespace ClassyElectronics
{
    public class TurnTable
    {
        public double CurrentSpeed { get; set; }
        public bool IsPlaying { get; set; }
        public void Play()
        {
            IsPlaying = true;
        }
        public void Stop()
        {
            IsPlaying = false;
        }
    }
}