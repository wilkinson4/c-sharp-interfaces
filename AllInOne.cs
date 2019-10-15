using System.Collections.Generic;

namespace ClassyElectronics
{
    public class AllInOne : ITurnTable, ISpeaker, IRadio
    {
        public double CurrentSpeed { get; set; }
        public bool IsPlaying { get; set; }
        public int Volume { get; set; }
        public double CurrentFrequency { get; set; }
        public List<double> FavoriteStations { get; set; }
        public bool IsRadioOn { get; set; }

        public void AddFavorite(double station)
        {
            FavoriteStations.Add(station);
        }

        public void Play()
        {
            IsPlaying = true;
        }

        public void RemoveFavorite(double station)
        {
            FavoriteStations.Remove(station);
        }

        public void Stop()
        {
            IsPlaying = false;
        }

        public void TurnRadioOff()
        {
            IsRadioOn = false;
        }

        public void TurnRadioOn()
        {
            IsRadioOn = true;
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