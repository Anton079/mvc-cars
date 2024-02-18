using MVC_cars;
using System.ComponentModel;

internal class Program
{
    public static void Main(string[] args)
    {
       

        MasinaService service = new MasinaService();

        

        service.LoadData();


        service.AfisareMasini();

         List<Masina> masini=  service.FilterMasinaByCuloare("Albastru");
         foreach(Masina x in masini)
         {
            Console.WriteLine(x.marca);
         }



        Masina maxima=service.FindMasinaGreutateMaxima();


        Console.WriteLine(  maxima.MasiniInfo());



    }
}