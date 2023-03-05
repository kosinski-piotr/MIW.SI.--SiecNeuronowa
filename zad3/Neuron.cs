using System.Collections.Generic;
using System.Linq;

namespace zad3
{       public class Neuron
    {
        public List<double> wagi = new List<double>();
        public double ukryteWejscie = 1;
        public double wyjscie;
        public double korekta;

        public void zmienWagi(List<double> wejscia)
        {
            wagi[0] += korekta;
            for (int i = 1; i < wagi.Count(); i++)
            {
                wagi[i] += korekta * wejscia[i - 1];
            }
        }

    }
}

