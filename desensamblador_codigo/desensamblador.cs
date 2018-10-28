using System;
using System.Linq;
using InstructionsNameSpace;

namespace DesensambladorNameSpace
{
    class Desensamblador
    {   
        public InstructionSet setInstrucciones;
        public Desensamblador(ref InstructionSet setInstrucciones){
            this.setInstrucciones = setInstrucciones;
        }

        public void desensamblar(string origen){
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(origen);  
            while((line = file.ReadLine()) != null)  
            {  
                string[] palabras = line.Split(' ');
                //string instruccion = "Instrucción: ";
                if(palabras.Length == 3){
                    try
                    {
                        int param = System.Convert.ToInt32(palabras[2]);//Primero se intenta convertir el parámetro a número
                        setInstrucciones.addInst(palabras[1], param);
                    }
                    catch (FormatException)
                    {
                        setInstrucciones.addInst(palabras[1], palabras[2]);//Si el parámetro no es un número, entonces es un string o char 
                        //Aún falta definir qué sucede si es char
                    }
                }
                else{
                    setInstrucciones.addInst(palabras[1], null);//La instrucción no contiene parámetro.
                }

            }  
            file.Close();
        }
        
    }
}
