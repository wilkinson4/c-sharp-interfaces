namespace ClassyElectronics
{
    public class Speakinator3001 : TurnTable
    {
        public int Volume { get; set; }
        public void VolumeUp()
        {
            Volume++;
        }
        public void VolumeDown()
        {
            Volume--;
        }
    }
}