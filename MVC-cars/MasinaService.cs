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
        private List<Masina> _MasinaList;

        public MasinaService()
        {
            _MasinaList = new List<Masina>();
            this.LoadData();
        }


        //metode
        public  void LoadData()
        {
            Masina masina1 = new Masina();
            masina1.Greutate = 2000;
            masina1.Inaltime = 10;
            masina1.Latime = 2;
            masina1.Marca = "Dacia";
            masina1.Culoare = "Albastru";
            masina1.Inchiriata = true;

            Masina masina2 = new Masina();
            masina2.Greutate = 2500;
            masina2.Inaltime = 25;
            masina2.Latime = 15;
            masina2.Culoare = "Albastru";
            masina2.Marca = "Mercedes";
            masina2.Inchiriata = false;

            Masina masina3 = new Masina();
            masina3.Greutate = 3500;
            masina3.Latime = 15;
            masina3.Inaltime = 60;
            masina3.Marca = "Audi";
            masina3.Culoare = "Gri";
            masina3.Inchiriata = false;

            Masina masina4 = new Masina();
            masina4.Greutate = 5700;
            masina4.Inaltime = 3600;
            masina4.Latime = 40;
            masina4.Marca = "Nissan";
            masina4.Culoare = "Argintiu";
            masina4.Inchiriata = true;

            Masina masina5 = new Masina();
            masina5.Marca = "Ford";
            masina5.Latime = 65;
            masina5.Inaltime = 60;
            masina5.Culoare = "gri";
            masina5.Greutate = 30;
            masina5.Inchiriata = false;


            this._MasinaList.Add(masina5);
            this._MasinaList.Add(masina4);
            this._MasinaList.Add(masina3);
            this._MasinaList.Add(masina2);
            this._MasinaList.Add(masina1);
        }

        //CRUD
        public bool AddMasiniLista(Masina masinaNoua)
        {
            if (FindMasinaByMarca(masinaNoua.Marca) == -1)
            {
                this._MasinaList.Add(masinaNoua);
                return true;
            }
            return false;
        }

        public bool RemoveMasinaByMarca(string MarcaCarCautata)
        {
            int MasinaCautata = FindMasinaByMarca(MarcaCarCautata);
            if(MasinaCautata == -1)
            {
                _MasinaList.RemoveAt(MasinaCautata);
                return true;
            }
            return false;
        }

        public int FindMasinaByMarca(string marcaCautata)
        {
            for(int i = 0; i < _MasinaList.Count; i++)
            {
                if (_MasinaList[i].Marca.Equals(marcaCautata))
                {
                    return i;
                }
            }
            return -1;
        }

        //View
        public void AfisareMasini()
        {
            foreach(Masina masina in _MasinaList)
            {

                Console.WriteLine(masina.MasiniInfo());

            }
        }

        public void AfisareMasiniDisponibile()
        {
            for(int i = 0; i< _MasinaList.Count; i++)
            {
                if (_MasinaList[i].Inchiriata == false)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void AfisareMasiniByMarca(string MarcaMasinii)
        {
            foreach (Masina x in _MasinaList)
            {
                if (x.Marca.Equals(MarcaMasinii))
                {
                    Console.WriteLine(x.MasiniInfo());
                }
            }

            
        }


        public bool InchiriazaMasinaByDenumire(string Marca)
        {
            int poz = FindMasinaByMarca(Marca);
            if (_MasinaList[poz].Inchiriata == false)
            {
                _MasinaList[poz].Inchiriata = true;
                return true;
            }

            return false;
        }

        public bool AddCarInList(Masina MasinaNoua)
        {
            if(FindMasinaByMarca(MasinaNoua.Marca) != -1)
            {
                this._MasinaList.Add(MasinaNoua);
                return true;
            }
            return false;
        }

        //Edit
        public bool EditMasinaGreutate(string car, int CarGreutate)
        {
            foreach (Masina x in _MasinaList)
            {
                if (x.Marca == car)
                {
                    x.Greutate = CarGreutate;
                    return true;
                }
            }
            return false;
        }

        public bool EditMasinaCuloare(string car, int CarCuloare)
        {
            foreach (Masina x in _MasinaList)
            {
                if (x.Marca == car)
                {
                    x.Greutate = CarCuloare;
                    return true;
                }
            }
            return false;
        }

        //Filtru
        public List<Masina> FilterCarByMarca(string marcaAlesa)
        {
            List<Masina> carListMarca = new List<Masina>();

            foreach (Masina x in _MasinaList)
            {
                if (marcaAlesa.Equals(x.Marca))
                {
                    carListMarca.Add(x);
                }
            }
            return carListMarca;
        }

        public List<Masina> FilterMarcaByGreutate(string marcaAlesa)
        {
            List<Masina> carListGreutate = new List<Masina>();

            foreach (Masina x in _MasinaList)
            {
                if (marcaAlesa.Equals(x.Greutate))
                {
                    carListGreutate.Add(x);
                }
            }
            return carListGreutate;
        }
    }
}
