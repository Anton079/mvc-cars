using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_cars
{
    public class MasinaService
    {
        //atribute
        public List<Masina> MasinaList = new List<Masina>();


        //metode
        public  void LoadData()
        {
            Masina masina1 = new Masina();
            masina1.greutate = 2000;
            masina1.inaltime = 10;
            masina1.latime = 2;
            masina1.marca = "Dacia";
            masina1.culoare = "Albastru";

            Masina masina2 = new Masina();
            masina2.greutate = 2500;
            masina2.inaltime = 25;
            masina2.latime = 15;
            masina2.culoare = "Albastru";
            masina2.marca = "Mercedes";

            Masina masina3 = new Masina();
            masina3.greutate = 3500;
            masina3.latime = 15;
            masina3.inaltime = 60;
            masina3.marca = "Audi";
            masina3.culoare = "Gri";

            Masina masina4 = new Masina();
            masina4.greutate = 5700;
            masina4.inaltime = 3600;
            masina4.latime = 40;
            masina4.marca = "Nissan";
            masina4.culoare = "Argintiu";

            Masina masina5 = new Masina();
            masina5.marca = "Ford";
            masina5.latime = 65;
            masina5.inaltime = 60;
            masina5.culoare = "gri";
            masina5.greutate = 30;

          
            this.MasinaList.Add(masina5);
            this.MasinaList.Add(masina4);
            this.MasinaList.Add(masina3);
            this.MasinaList.Add(masina2);
            this.MasinaList.Add(masina1);
        }



        //metoda ce  returneaza o lista cu toate masinile de o anumtia culoare
        public List<Masina> FilterMasinaByCuloare(string culoare)
        {

            List<Masina> masiniFiltersByCuloare = new List<Masina>();

            foreach(Masina x in MasinaList)
            {
                if(culoare.Equals(x.culoare) )
                {


                    masiniFiltersByCuloare.Add(x);
                }
            }
            return masiniFiltersByCuloare;
        }


        //functie ce returneaza o masina cu greutatea ce-a mai mare
        public Masina FindMasinaGreutateMaxima()
        {
            int greutateMax = 0;
            Masina modelMasina = MasinaList[0];
            foreach(Masina car in MasinaList)
            {
                if(car.greutate > greutateMax)
                {
                    greutateMax = car.greutate;
                    modelMasina = car;
                }
            }
            return modelMasina;
        }


        //CRUD
        public void AfisareMasini()
        {
            foreach(Masina masina in MasinaList)
            {

                Console.WriteLine(masina.MasiniInfo());

            }
        }

        public int FindMasinaByMarca(string marcaCautata)
        {
            for(int i = 0; i < MasinaList.Count; i++)
            {
                if (MasinaList[i].marca.Equals(marcaCautata))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool AddMasiniLista(Masina masinaNoua)
        {
            if (FindMasinaByMarca(masinaNoua.marca) == -1)
            {
                this.MasinaList.Add(masinaNoua);
                return true;
            }
            return false;
        }

        public bool RemoveMasinaByMarca(string MarcaCarCautata)
        {
            int MasinaCautata = FindMasinaByMarca(MarcaCarCautata);
            if(MasinaCautata == -1)
            {
                MasinaList.RemoveAt(MasinaCautata);
                return true;
            }
            return false;
        }

    }


}
