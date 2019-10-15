using System.Collections.Generic;

namespace ClassyElectronics
{
    public interface IRadio
    {
        double CurrentFrequency { get; set; }
        List<double> FavoriteStations { get; set; }
        bool IsRadioOn { get; set; }
        void AddFavorite(double station);
        void RemoveFavorite(double station);
        void TurnRadioOn();
        void TurnRadioOff();
        
    }
}