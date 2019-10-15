using System;
using System.Collections.Generic;

namespace ClassyElectronics
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio aRadio = new Radio();
            Radio anotherRadio = new Radio();
            AllInOne anAllInOne = new AllInOne();
            AllInOne anotherAllInOne = new AllInOne();


            List<IRadio> iradioList = new List<IRadio>()
            {
                aRadio, anotherRadio, anotherAllInOne, anAllInOne
            };

            TestRadios(iradioList);

            Turntable aTurntable = new Turntable();
            aTurntable.CurrentSpeed = 2.3;
            Turntable anotherTurnTable = new Turntable();
            anotherTurnTable.CurrentSpeed = 3.2;

            List<ITurnTable> iturnTableList = new List<ITurnTable>(){
                aTurntable, anotherTurnTable
            };

            TestTurntables(iturnTableList);
        }
        static void TestRadios(List<IRadio> radios)
        {
            foreach (IRadio radio in radios)
            {
                radio.TurnRadioOn();
                radio.TurnRadioOff();
            }
        }
        static void TestTurntables(List<ITurnTable> turntables)
        {
            foreach (Turntable turntable in turntables)
            {
                turntable.Play();
                turntable.Stop();
            }
        }
    }
}
