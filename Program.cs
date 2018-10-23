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
         
        // TESTING PRELIMINARY DATA STRUCTURE:
            almacen.setValue("KEY 1", 1);
            almacen.setValue("KEY 2", 'a');
            almacen.setValue("KEY 3", 2);
            almacen.setValue("KEY 4", 'b');
            almacen.printContainer();
            almacen.searchValue("KEY 2");
            almacen.updateValue("KEY 2", 666);
            almacen.getValue("KEY 2");
        // ------------------------------------
        }
    }
}
