using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace zad3
{

    public class Siec
    {
        public List<Warstwa> warstwy = new List<Warstwa>();
        public double[] wejscia;

        public void stworz(string wartosci)
        {




            List<int> neuronyNaWarstwe = wartosci
                     .Trim()
                     .Split(' ')
                     .Select(int.Parse)
                     .ToList();

            wejscia = new double[neuronyNaWarstwe[0]];

            for (int i = 1; i < neuronyNaWarstwe.Count(); i++)
            {
                Warstwa warstwa = new Warstwa();
                for (int j = 0; j < neuronyNaWarstwe[i]; j++)
                {
                    Neuron neuron = new Neuron();
                    warstwa.listaNeuronow.Add(neuron);
                }
                warstwy.Add(warstwa);
            }
        }



        public void genWagi(double pocz, double kon)
        {
            Random random = new Random();

            int sumNPoprzednWar = wejscia.Length;
            for (int i = 0; i < warstwy.Count(); i++)
            {
                for (int j = 0; j < warstwy[i].listaNeuronow.Count(); j++)
                {
                    List<double> wagi = new List<double>();
                    for (int k = 0; k < sumNPoprzednWar + 1; k++)
                    {
                        wagi.Add(random.NextDouble() * (kon - pocz) + pocz);
                    }
                    warstwy[i].listaNeuronow[j].wagi = wagi;
                }
                sumNPoprzednWar = warstwy[i].listaNeuronow.Count();
            }
        }

        public static double fSigma(double suma, double beta)
        {
            return 1 / (1 + Math.Exp(-beta * suma));
        }

        public void licz1(double beta)
        {
            for (int i = 0; i < warstwy[0].listaNeuronow.Count(); i++)
            {
                double suma = warstwy[0].listaNeuronow[i].ukryteWejscie * warstwy[0].listaNeuronow[i].wagi[0];

                for (int j = 0; j < wejscia.Count(); j++)
                {
                    suma += wejscia[j] * warstwy[0].listaNeuronow[i].wagi[j + 1];
                }

                warstwy[0].listaNeuronow[i].wyjscie = fSigma(suma, beta);
            }
        }


        public void licz2(double beta)
        {
            for (int i = 1; i < warstwy.Count(); i++)
            {
                for (int j = 0; j < warstwy[i].listaNeuronow.Count(); j++)
                {
                    double suma = warstwy[i].listaNeuronow[j].ukryteWejscie * warstwy[i].listaNeuronow[j].wagi[0];
                    for (int k = 0; k < warstwy[i - 1].listaNeuronow.Count(); k++)
                    {
                        suma += warstwy[i - 1].listaNeuronow[k].wyjscie * warstwy[i].listaNeuronow[j].wagi[k + 1];
                    }
                    warstwy[i].listaNeuronow[j].wyjscie = fSigma(suma, beta);
                }
            }
        }

        public double korektap(double ni, double prawWyj, double wyjWars)
        {
            double policzona;

            double blad = prawWyj - wyjWars;
            policzona = ni * blad;

            return policzona;
        }

        public double korektan(double korektaP, double waga)
        {
            double policzona = korektaP * waga;

            return policzona;
        }

        public double sp(double korekta, double beta, double wyjWars)
        {
            double policzone;

            double blad = 1 - wyjWars;
            policzone = korekta*beta*wyjWars*blad;

            return policzone;
        }



        public void Propagacja(double ni, double beta, Probka probka)
        {
            int ost = warstwy.Count() - 1;
            for (int i = 0; i < warstwy[ost].listaNeuronow.Count(); i++)
            {
    
                double korekta = korektap(ni, probka.prawidloweWyjscie[i], warstwy[ost].listaNeuronow[i].wyjscie);
                double s = sp(korekta, beta, warstwy[ost].listaNeuronow[i].wyjscie);
                warstwy[ost].listaNeuronow[i].korekta = s;

                List<double> wejscia = new List<double>();

                for (int x = 0; x < warstwy[ost - 1].listaNeuronow.Count(); x++)
                {
                    wejscia.Add(warstwy[ost - 1].listaNeuronow[x].wyjscie);

                }
                warstwy[ost].listaNeuronow[i].zmienWagi(wejscia);

            }

            for (int i = warstwy.Count() - 2; i >= 0; i--)
            {
                for (int j = 0; j < warstwy[i].listaNeuronow.Count(); j++)
                {
                    for (int k = 0; k < warstwy[i + 1].listaNeuronow.Count(); k++)
                    {

                        double korekta = korektan(warstwy[i + 1].listaNeuronow[k].korekta, warstwy[i + 1].listaNeuronow[k].wagi[j + 1]);
                        double s = sp(korekta, beta, warstwy[i].listaNeuronow[j].wyjscie);

                        warstwy[i].listaNeuronow[j].korekta = s;
       
                        List<double> wejscia= new List<double>();
                        if (i == 0)
                        {
                            wejscia = probka.wejscia;
                        }
                        else
                        {
                            for(int x = 0; x<warstwy[i-1].listaNeuronow.Count(); x++)
                            {
                                wejscia.Add(warstwy[i - 1].listaNeuronow[x].wyjscie);

                            }
                        }

                        warstwy[i].listaNeuronow[j].zmienWagi(wejscia);


                    }
                }
            }
        }
        public void Ucz(int epoki, List<Probka> probki, double ni, double beta)
        {
            for (int i = 0; i < epoki; i++)
            {
                for (int j = 0; j < probki.Count(); j++)
                {
                    wejscia = probki[j].wejscia.ToArray();
                    licz1(beta);
                    licz2(beta);
                    Propagacja(ni, beta, probki[j]);
                }
            }
        }
        public string wypisz(List<Probka> probki, double beta)
        {
            string wypis = "";
            for (int j = 0; j < probki.Count(); j++)
            {
                wejscia = probki[j].wejscia.ToArray();
                licz1(beta);
                licz2(beta);
                wypis += string.Join(" ", wejscia) + " = ";
                wypis += string.Join(" ", probki[j].prawidloweWyjscie) + " | ";

                for (int i = 0; i < warstwy[warstwy.Count() - 1].listaNeuronow.Count(); i++)
                {
                    wypis += warstwy[warstwy.Count() - 1].listaNeuronow[i].wyjscie + " blad: ";
                    //                   wypis += " " + Math.Abs(probki[j].prawidloweWyjscie[i] - warstwy[warstwy.Count() - 1].listaNeuronow[i].wyjscie) + " ";
                    wypis +=  Math.Abs(probki[j].prawidloweWyjscie[i] - warstwy[warstwy.Count() - 1].listaNeuronow[i].wyjscie) + " ";

                }
                wypis += "\n";
            }
            return wypis;
        }

    }
}
       

