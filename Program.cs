using System;

namespace Minics.exe
{
    class Program
    {
        static void Main(string[] args)
        {
            // dotnet run: correr c#
            Almacen almacen = new Almacen("almacen");
            Console.WriteLine(almacen.nombre);
        }
    }
}
