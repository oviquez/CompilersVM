using System;

public class Almacen{

    /*
    permite almacenar tuplas de variables y 
    valores (enteros y chars) que serán utilizados por el intérprete para resolver las operaciones de busqueda y
    almacenamiento de identificadores. 
    Así mismo debe almacenar referencias a métodos que deben llevar la "dirección" en el código que tiene dicho método.
     */

    public String nombre;

    // constructor
    public Almacen(String nombre)
    {
        this.nombre = nombre;
    }
}