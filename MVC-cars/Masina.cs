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
        public int greutate;
        public string culoare;
        public string marca;
        public int inaltime;
        public int latime;

        public string MasiniInfo()
        {
            string text = " ";
            text += "Greutatea " + greutate + "\n";
            text += "Culoarea " + culoare + "\n";
            text += "Marca " + marca + "\n";
            text += "Inaltimea " + inaltime + "\n";
            text += "Latimea " + latime + "\n";
            return text;
        }

    }
}
