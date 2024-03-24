using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MVC_cars
{
    public class Masina
    {
        public int _greutate;
        public string _culoare;
        public string _marca;
        public int _inaltime;
        public int _latime;
        public bool _inchiriata;

        public string MasiniInfo()
        {
            string text = " ";
            text += "Greutatea " + Greutate + "\n";
            text += "Culoarea " + Culoare + "\n";
            text += "Marca " + Marca + "\n";
            text += "Inaltimea " + Inaltime + "\n";
            text += "Latimea " + Latime + "\n";
            text += "Inchiriata" + Inchiriata + "\n";
            return text;
        }

        public int Greutate
        {
            get { return _greutate; }
            set { _greutate = value; }
        }

        public string Culoare
        {
            get { return _culoare; }
            set { _culoare = value; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public int Inaltime
        {
            get { return _inaltime; }
            set { _inaltime = value; }
        }

        public int Latime
        {
            get { return _latime; }
            set { _latime = value; }
        }

        public bool Inchiriata
        {
            get { return _inchiriata; }
            set { _inchiriata = value;}
        }
    }
}
