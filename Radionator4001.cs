using System.Collections.Generic;

namespace ClassyElectronics
{
    public class Radionator4001 : Speakinator3001
    {
        public double CurrentFrequency { get; set; }
        public List<double> FavoriteStations { get; set; } = new List<double>();
        public bool IsRadioOn { get; set; }
        public void AddFavorite(double station)
        {
            FavoriteStations.Add(station);
        }
        public void RemoveFavorite(double station)
        {
            FavoriteStations.Remove(station);
        }
        public void TurnRadioOn()
        {
            IsRadioOn = true;
        }
        public void TurnRadioOff()
        {
            IsRadioOn = false;
        }
    }
}