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
            masina1.inchiriata = true;

            Masina masina2 = new Masina();
            masina2.greutate = 2500;
            masina2.inaltime = 25;
            masina2.latime = 15;
            masina2.culoare = "Albastru";
            masina2.marca = "Mercedes";
            masina2.inchiriata = false;

            Masina masina3 = new Masina();
            masina3.greutate = 3500;
            masina3.latime = 15;
            masina3.inaltime = 60;
            masina3.marca = "Audi";
            masina3.culoare = "Gri";
            masina3.inchiriata = false;

            Masina masina4 = new Masina();
            masina4.greutate = 5700;
            masina4.inaltime = 3600;
            masina4.latime = 40;
            masina4.marca = "Nissan";
            masina4.culoare = "Argintiu";
            masina4.inchiriata = true;

            Masina masina5 = new Masina();
            masina5.marca = "Ford";
            masina5.latime = 65;
            masina5.inaltime = 60;
            masina5.culoare = "gri";
            masina5.greutate = 30;
            masina5.inchiriata = false;


            this.MasinaList.Add(masina5);
            this.MasinaList.Add(masina4);
            this.MasinaList.Add(masina3);
            this.MasinaList.Add(masina2);
            this.MasinaList.Add(masina1);
        }

        //CRUD
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

        //View
        public void AfisareMasini()
        {
            foreach(Masina masina in MasinaList)
            {

                Console.WriteLine(masina.MasiniInfo());

            }
        }

        public void AfisareMasiniDisponibile()
        {
            for(int i = 0; i<MasinaList.Count; i++)
            {
                if (MasinaList[i].inchiriata == false)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void AfisareMasiniByMarca(string MarcaMasinii)
        {
            foreach (Masina x in MasinaList)
            {
                if (x.marca.Equals(MarcaMasinii))
                {
                    Console.WriteLine(x.MasiniInfo());
                }
            }

            
        }


        public bool InchiriazaMasinaByDenumire(string Marca)
        {
            int poz = FindMasinaByMarca(Marca);
            if (MasinaList[poz].inchiriata == false)
            {
                MasinaList[poz].inchiriata = true;
                return true;
            }

            return false;
        }

        public bool AddCarInList(Masina MasinaNoua)
        {
            if(FindMasinaByMarca(MasinaNoua.marca) != -1)
            {
                this.MasinaList.Add(MasinaNoua);
                return true;
            }
            return false;
        }

        //Edit
        public bool EditMasinaGreutate(string car, int CarGreutate)
        {
            foreach (Masina x in MasinaList)
            {
                if (x.marca == car)
                {
                    x.greutate = CarGreutate;
                    return true;
                }
            }
            return false;
        }

        public bool EditMasinaCuloare(string car, int CarCuloare)
        {
            foreach (Masina x in MasinaList)
            {
                if (x.marca == car)
                {
                    x.greutate = CarCuloare;
                    return true;
                }
            }
            return false;
        }

        //Filtru
        public List<Masina> FilterCarByMarca(string marcaAlesa)
        {
            List<Masina> carListMarca = new List<Masina>();

            foreach (Masina x in MasinaList)
            {
                if (marcaAlesa.Equals(x.marca))
                {
                    carListMarca.Add(x);
                }
            }
            return carListMarca;
        }

        public List<Masina> FilterMarcaByGreutate(string marcaAlesa)
        {
            List<Masina> carListGreutate = new List<Masina>();

            foreach (Masina x in MasinaList)
            {
                if (marcaAlesa.Equals(x.greutate))
                {
                    carListGreutate.Add(x);
                }
            }
            return carListGreutate;
        }
    }
}
