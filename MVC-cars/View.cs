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
            Console.WriteLine("Apasati tasta 1 pentru a afisa toate masinile disponibile");
            Console.WriteLine("Apasati tasta 2 pentru a afisa toate masinile cu o marca anume");
            Console.WriteLine("Apasati tasta 3 pentru a adauga o masina in lista");
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
                        masinaService.AfisareMasinaByMarcaEi();
                        break;

                }
            }
        }


    }
}
