﻿using MVC_cars;
using System.ComponentModel;

internal class Program
{
    public static void Main(string[] args)
    {
       

        MasinaService service = new MasinaService();



        service.LoadData();


        service.AfisareMasini();
        
    }
}