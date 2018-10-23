using System;


class Desensamblador
{    public Desensamblador(){
    }

    public void desensamblar(string origen){
        string line;
        System.IO.StreamReader file = new System.IO.StreamReader(origen);  
        while((line = file.ReadLine()) != null)  
        {  
            System.Console.WriteLine("instrucción: " + line);  
        }  
        file.Close();
    }
    
}
