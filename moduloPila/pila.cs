using System;
using System.Collections;

namespace moduloPila
{
    public class Pila
    {

        Stack pila = new Stack ();

        public void push (Object obj){
            pila.Push(obj);
        }

        public void pop(Object obj){
            pila.Pop ();
        }

       public void imprimir () {
        foreach ( Object obj in pila) {
        Console.Write( "    {0}", obj );
        }
       }
       
         


            
    }
}
