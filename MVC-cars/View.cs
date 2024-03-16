using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_cars
{
    public class View
    {
        MasinaService masinaService = new MasinaService();

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa toate masinile");
            Console.WriteLine("Apasati tasta 2 pentru a afisa toate masinile disponibile");
            Console.WriteLine("Apasati tasta 3 pentru a afisa toate masinile cu o marca anume");
            Console.WriteLine("Apasati tasta 4 pentru a inchiria o masina");
            Console.WriteLine("Apasati tasta 5 pentru a modifica detaliile unei masini"); //EROARE
            Console.WriteLine("Apasati tasta 6 pentru a adauga o masina");
            Console.WriteLine("Apasati tasta 7 pentru a edita greutatea masinii");
            Console.WriteLine("Apasati tasta 8 pentru a edita culoarea unei masini anume");
            Console.WriteLine("Apasati tasta 9 si inserati brandul pe care il doriti masina");
            Console.WriteLine("Apasati tasta 10 si inserati greutate pe care o doriti la masina");
        }

        public void play()
        {
            bool running = true;

            masinaService.LoadData();
            while (running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch(alegere)
                {
                    case "1":
                        masinaService.AfisareMasini(); 
                        break;

                    case "2":
                        masinaService.AfisareMasiniDisponibile();
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

                }
            }
        }

        public void AfisareMasinaByMarca()
        {
            Console.WriteLine("Ce masina doriti sa vedeti?");
            string masina= Console.ReadLine();

            if(masinaService.FindMasinaByMarca(masina) != -1)
            {
                Console.WriteLine("Avem aceasta masina!");                   
            }
            else
            {
                Console.WriteLine("Nu detinem aceasta marca");
            }
        }

        public void inchiriazaMasina()
        {
            Console.WriteLine("Ce masina doriti sa inchiriati?");
            string masinaIn = Console.ReadLine();

            int poz = masinaService.FindMasinaByMarca(masinaIn);

            if(poz != -1)
            {
                bool inchiriata = masinaService.InchiriazaMasinaByDenumire(masinaIn);

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
            masina6.marca = marcaNou;
            masina6.latime = latimeNou;
            masina6.inaltime = inaltimeNou;
            masina6.inchiriata = inchiriataNou;
            masina6.culoare = culoareNoua;
            masina6.greutate = greutateNou;

            Console.WriteLine("Masina adaugata cu succes!");
        }

        public void EditGreutateMasini()
        {
            Console.WriteLine("Ce masina doriti sa modificati");
            string MasinaAlesa = Console.ReadLine();

            Console.WriteLine("Cu ce greutate doriti sa modificati la masina");
            int newGreutateCar = Int32.Parse(Console.ReadLine());

            if (masinaService.EditMasinaGreutate(MasinaAlesa, newGreutateCar))
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

            if (masinaService.(MasinaAlesa, newCuloare))
            {
                Console.WriteLine("Modificarea a reusit");
            }
            else
            {
                Console.WriteLine("Modificarea nu a reusit");
            }
        }

        //Functie view pentru filtru tasta 9

        //Functie view pentru filtru tasta 10
    }
}
