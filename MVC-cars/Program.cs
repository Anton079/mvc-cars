using MVC_cars;
using System.ComponentModel;

internal class Program
{
    public static void Main(string[] args)
    {
       

        MasinaService service = new MasinaService();

        

        View view = new View();
        service.LoadData();


        view.play();




    }
}