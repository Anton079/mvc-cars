using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_cars
{
    public class View
    {
        private MasinaService _masinaService;

        public View()
        {
            _masinaService = new MasinaService();
        }

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa toate masinile");
            Console.WriteLine("Apasati tasta 2 pentru a afisa toate masinile disponibile");
            Console.WriteLine("Apasati tasta 3 pentru a afisa toate masinile cu o marca anume");
            Console.WriteLine("Apasati tasta 4 pentru a inchiria o masina");
            Console.WriteLine("Apasati tasta 5 pentru a modifica detaliile unei masini"); 
            Console.WriteLine("Apasati tasta 6 pentru a adauga o masina");
            Console.WriteLine("Apasati tasta 7 pentru a edita greutatea masinii");
            Console.WriteLine("Apasati tasta 8 pentru a edita culoarea unei masini anume");
            Console.WriteLine("Apasati tasta 9 si inserati brandul pe care il doriti masina");
            Console.WriteLine("Apasati tasta 10 si inserati greutate pe care o doriti la masina");
            Console.WriteLine("Apasati tasta 11 pentru a da remove la o masina dorita");
        }

        public void play()
        {
            bool running = true;

            _masinaService.LoadData();
            while (running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch(alegere)
                {
                    case "1":
                        _masinaService.AfisareMasini(); 
                        break;

                    case "2":
                        _masinaService.AfisareMasiniDisponibile();
                        break;

                    case "3":
                        AfisareMasinaByMarca();
                        break;

                    case "4":
                        inchiriazaMasina();
                        break;

                    case "5":

                        break;

                    case "6":
                        AddCarInList();
                        break;

                    case "7":
                        EditGreutateMasini();
                        break;

                    case "8":
                        EditCuloareaMasina();
                        break;

                    case "11":
                        RemoveCarByType();
                        break;

                }
            }
        }

        public void AfisareMasinaByMarca()
        {
            Console.WriteLine("Ce masina doriti sa vedeti?");
            string masina= Console.ReadLine();

            if(_masinaService.FindMasinaByMarca(masina) != -1)
            {
                Console.WriteLine("Avem aceasta masina!");                   
            }
            else
            {
                Console.WriteLine("Nu detinem aceasta marca");
            }
        }

        public void RemoveCarByType()
        {
            Console.WriteLine("Ce masina doriti sa stergeti din lista de mai jos?");
            _masinaService.AfisareMasini();
            string masinaDorita = Console.ReadLine();

            if (_masinaService.RemoveMasinaByMarca(masinaDorita) != null)
            {
                _masinaService.RemoveMasinaByMarca(masinaDorita);
                Console.WriteLine("Masina a fost stearsa cu succes");
            }
            else
            {
                Console.WriteLine("Masina nu a fost gasita");
            }

            
        }

        public void inchiriazaMasina()
        {
            Console.WriteLine("Ce masina doriti sa inchiriati?");
            string masinaIn = Console.ReadLine();

            int poz = _masinaService.FindMasinaByMarca(masinaIn);

            if(poz != -1)
            {
                bool inchiriata = _masinaService.InchiriazaMasinaByDenumire(masinaIn);

                if(inchiriata)
                {
                    Console.WriteLine("Masina a fost rezervata cu succes");
                }
                else
                {
                    Console.WriteLine("Masina nu poate fi rezervata");
                }
            }

        }

        public void AddCarInList()
        {
            Console.WriteLine("Ce marca doriti sa adaugati?");
            string marcaNou= Console.ReadLine();

            Console.WriteLine("Ce greutate are masina?");
            int greutateNou=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ce culoare are masina?");
            string culoareNoua = Console.ReadLine();

            Console.WriteLine("Ce intaltime are masina?");
            int inaltimeNou = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ce latime are masina?");
            int latimeNou = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Este inchiriata masina");
            bool inchiriataNou = Boolean.Parse(Console.ReadLine());

            Masina masina6 = new Masina();
            masina6.Marca = marcaNou;
            masina6.Latime = latimeNou;
            masina6.Inaltime = inaltimeNou;
            masina6.Inchiriata = inchiriataNou;
            masina6.Culoare = culoareNoua;
            masina6.Greutate = greutateNou;

            Console.WriteLine("Masina adaugata cu succes!");
        }

        public void EditGreutateMasini()
        {
            Console.WriteLine("Ce masina doriti sa modificati");
            string MasinaAlesa = Console.ReadLine();

            Console.WriteLine("Cu ce greutate doriti sa modificati la masina");
            int newGreutateCar = Int32.Parse(Console.ReadLine());

            if (_masinaService.EditMasinaGreutate(MasinaAlesa, newGreutateCar))
            {
                Console.WriteLine("Modificarea a reusit");
            }
            else
            {
                Console.WriteLine("Modificarea nu a reusit");
            }
        }

        public void EditCuloareaMasina()
        {
            Console.WriteLine("Ce masina doriti sa modificati");
            string MasinaAlesa = Console.ReadLine();

            Console.WriteLine("Cu ce culoare doriti sa modificati la masina");
            int newCuloare = Int32.Parse(Console.ReadLine());

            if (_masinaService.EditMasinaCuloare(MasinaAlesa, newCuloare))
            {
                Console.WriteLine("Modificarea a reusit");
            }
            else
            {
                Console.WriteLine("Modificarea nu a reusit");
            }
        }

    }
}
