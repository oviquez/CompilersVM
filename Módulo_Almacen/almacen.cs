using System;
using System.Collections.Generic;
public class Almacen{

    /*
    permite almacenar tuplas de variables y 
    valores (enteros y chars) que serán utilizados por el intérprete para resolver las operaciones de busqueda y
    almacenamiento de identificadores. 
    Así mismo debe almacenar referencias a métodos que deben llevar la "dirección" en el código que tiene dicho método.
     */

     // PRELIMINARY DATA STRUCTURE:
    Dictionary<string, dynamic> test;

    // -----------------------------
    public String nombre;

    // constructor
    public Almacen(String nombre)
    {
        this.test = new Dictionary<string, dynamic>();
        this.nombre = nombre;
    }

    // ADD VALUE TO THE DICTIONARY
    public void setValue(string key, dynamic value){
        this.test.Add(key, value);
    }
    // PRINT VALUE
    public void getValue(string key){
        foreach (dynamic item in this.test)
            {
                if (item.Key == key ){
                    Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
                }
                
            }
    }

    // GET VALUE IF FOUND
    public bool searchValue(string key){

        if(this.test.ContainsKey(key)){
            Console.WriteLine(key + " ITEM FOUND");
            return true;
        }
        return false;
        
    }

    // UPDATE VALUE IF FOUND
    public void updateValue(string key, dynamic newValue){
        bool found = searchValue(key);
        if(!found){
            Console.WriteLine("404 Item not found!");
        }
        else{
            this.test[key] = newValue;
            Console.WriteLine(key + " ITEM UPDATED!");
          
        }
    }

    // PRINT DICTIONARY
    public void printContainer(){
        foreach (dynamic item in this.test)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
    }

    

    public void almacenar(){}

    public void busqueda(){}
    
}