using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamming
{
    class Hamming_Class
    {
        int[] X; //wiadomosc
        int R;  //bity nadmiarowe
        Matrix macierz;
        double[] dane;
        List<double> wartość;
        int[] S; //kod nadmiarowy
        int[] S1; //kod nadmiarowy odpowiedzi
        int[] S2; //obliczony koda nadmiarowy odpowiedzi
        int[] Y; //wiaomosc odebrna

        public void wczytaj_kod(string txt, int opcja)
        {
            if (txt.Length <=2 )
            {
                MessageBox.Show("Podaj dane");
            }
            else
            {
                wartość = new List<double>();
                X = new int[txt.Length];
                for (int i = 0; i < X.Length; i++)
                {
                    X[i] = txt[i] - '0';
                }
                if (opcja == 0)
                    Generuj_macierz_d3();
                else
                    Generuj_macierz_d4();
            }
        }
        private void Generuj_macierz_d3()
        {
            R = (int)Math.Ceiling(Math.Log(X.Length, 2)) + 1;
            int liczba = 0;
            var number = "0";
            for (int i = 0; i < X.Length; i++)
            {
                do
                {
                    liczba++;
                    number = Convert.ToString(liczba, 2);
                } while (!sprawdz_ilosc_jedynek(number.ToString()));

                dodaj_dane(number);
                liczba++;
            }

            doda_macierz_jednostkowa();
            dane = new double[wartość.Count];
            for (int i = 0; i < wartość.Count; i++)
            {
                dane[i] = wartość[i];
            }
            macierz = new Matrix(R, R + X.Length);
            int k = 0;
            for (int i = 0; i < R + X.Length; i++)
            {
                for (int j = 0; j < R; j++)
                {
                    macierz.SetElement(j, i, dane[k]);
                    k++;
                }
            }
        }
        private void Generuj_macierz_d4()
        {
            R = (int)Math.Ceiling(Math.Log(X.Length, 2)) + 2;

            int liczba = 0;
            var number = "0";
            for (int i = 0; i < X.Length; i++)
            {
                do
                {
                    liczba++;
                    number = Convert.ToString(liczba, 2);


                } while (!sprawdz_ilosc_jedynek_dla_d4(number.ToString()));

                dodaj_dane(number);
                liczba++;
            }

            doda_macierz_jednostkowa();
            dane = new double[wartość.Count];
            for (int i = 0; i < wartość.Count; i++)
            {
                dane[i] = wartość[i];
            }
            macierz = new Matrix(R, R + X.Length);
            int k = 0;
            for (int i = 0; i < R + X.Length; i++)
            {
                for (int j = 0; j < R; j++)
                {
                    macierz.SetElement(j, i, dane[k]);
                    k++;
                }
            }
        }
        private bool sprawdz_ilosc_jedynek(string number)
        {
            int licznik = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] - '0' == 1.0)
                {
                    licznik++;
                }
                if (licznik > 1)
                {
                    return true;
                }
            }
            return false;
        }
        private bool sprawdz_ilosc_jedynek_dla_d4(string number)
        {
            int licznik = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] - '0' == 1.0)
                {
                    licznik++;
                }
            }
            if (licznik % 3 == 0)
                return true;
            else
                return false;
        }
        private void dodaj_dane(string number)
        {
            if (number.Length == R)
            {
                for (int i = 0; i < R; i++)
                {
                    wartość.Add(number[i] - '0');
                }
            }
            else
            {
                for (int i = number.Length; i < R; i++)
                {
                    wartość.Add(0);
                }
                for (int i = 0; i < number.Length; i++)
                {
                    wartość.Add(number[i] - '0');
                }
            }
        }
        private void doda_macierz_jednostkowa()
        {
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < R; j++)
                {
                    if (i == j)
                        wartość.Add(1.0);
                    else
                        wartość.Add(0.0);
                }
            }
        }
        public string oblicz_kod_nadmiarowy()
        {
            string kod = "";
            int pom = 0;
            S = new int[R];

            for (int i = 0; i < R; i++)
            {
                pom = 0;
                for (int k = 0; k < (wartość.Count / R) - R; k++)
                {
                    pom += ((int)macierz.GetElement(i, k) * X[k]);
                }
                kod += (pom % 2).ToString();
                S[i] = (pom % 2);
            }
            return kod;
        }
        public string pokaz_macierz()
        {
            string pokaz_macierz = "Macierz \n";
            for (int i = 0; i < R; i++)
            {
                pokaz_macierz += macierz.GetRow(i).ToString("F0") + "\n";
            }
            return pokaz_macierz;
        }
        public void wczytaj_odpowiedz(string text)
        {

            Y = new int[text.Length - R];
            for (int i = 0; i < Y.Length; i++)
            {
                Y[i] = text[i] - '0';
            }
            S1 = new int[R];
            for (int i = 0; i < R; i++)
            {
                S1[i] = text[i + Y.Length] - '0';
            }
        }
        public string sprawdz_syndrom()
        {
            bool syndrom = true;
            for (int i = 0; i < R; i++)
            {
                if (S1[i] != S2[i])
                {
                    syndrom = false;
                    break;
                }
            }
            if (syndrom == true)
            {
                return "brak bledu";
            }
            else
            {
                int[] spom = new int[macierz.ColumnCount];
                for (int i = 0; i < R; i++)
                {
                    spom[i] = (S1[i] + S2[i])%2;
                    
                }
                return sprawdz_kolumne(spom);
            }
        }
        public void oblicz_kod_nadmiarowy_dla_odpowiedzi()
        {

            int pom = 0;
            S2 = new int[R];

            for (int i = 0; i < R; i++)
            {
                pom = 0;
                for (int k = 0; k < (wartość.Count / R) - R; k++)
                {
                    pom += ((int)macierz.GetElement(i, k) * Y[k]);
                }

                S2[i] = (pom % 2);
            }
        }
        private string sprawdz_kolumne(int[] s)
        {
            
            bool spr = false;
            for (int k = 0; k < macierz.ColumnCount; k++)
            {
                for (int i = 0; i < R; i++)
                {
                    if (s[i] != macierz.GetElement(i,k))
                    {
                        spr = false;
                        break;
                    }
                    else
                    {
                        spr = true;
                    }
                }
                if (spr == true)
                {
                    return (k + 1).ToString();
                }
                else
                {
                    spr = false;
                }
            }
            return "brak kolumny";
        }
        public string zrob_jeden_blad()
        {
            StringBuilder wyraz = new StringBuilder();
            int bitt;
            for (int i = 0; i < X.Length; i++)
            {
                wyraz.Append(X[i].ToString());
            }
            for (int i = 0; i < S.Length; i++)
            {
                wyraz.Append(S[i].ToString());
            }
            Random rnd = new Random();
            bitt = rnd.Next(0, wyraz.Length);
            if (wyraz[bitt].ToString() == "0")
            {
                wyraz.Replace("0", "1", bitt, 1);
            }
            else if (wyraz[bitt].ToString() == "1")
            {
                wyraz.Replace("1", "0",bitt,1);
            }
            return wyraz.ToString();
        }   
        public string genruj_dwa_bledy()
        {
            StringBuilder wyraz = new StringBuilder();
            int bitt;
            for (int i = 0; i < X.Length; i++)
            {
                wyraz.Append(X[i].ToString());
            }
            for (int i = 0; i < S.Length; i++)
            {
                wyraz.Append(S[i].ToString());
            }
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                bitt = rnd.Next(0, wyraz.Length);

                if (wyraz[bitt].ToString() == "0")
                {
                    wyraz.Replace("0", "1", bitt, 1);
                }
                else if (wyraz[bitt].ToString() == "1")
                {
                    wyraz.Replace("1", "0", bitt, 1);
                }
            }
            return wyraz.ToString();
        }
    }
}
