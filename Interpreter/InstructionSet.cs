using System;
using System.Collections.Generic;
using AlmacenNameSpace;

namespace InstructionsNameSpace{
    class InstructionSet
    {   
        private LinkedList<KeyValuePair<string, dynamic>> instSet {get; set;}
        private Almacen almacenGlobal {get; set;} //se define un almacen global para manejo de variables globales y referencias a métodos
        public Almacen almacenLocal {get; set;} //se define un almacén local para variables locales *** PUEDE QUE SE REQUIERA UNO POR CADA CONTEXTO PERO ESO DEBE DEFINIRSE ***
        //private Pila pilaExprs {get; set;}
        public InstructionSet(){
            instSet = new LinkedList<KeyValuePair<string,dynamic>>() ;
            almacenGlobal = new Almacen("Global");
            almacenLocal = new Almacen("Local");
            test();
        }

        public void addInst(string inst, dynamic param){
            instSet.AddLast(new KeyValuePair<string, dynamic>(inst,param));
        }

        public void runPUSH_LOCAL_I(string name){ //podría recibir el almacen del contexto en caso de que se requiera
            //declara el elemento "name" en el almacen LOCAL con valor por defecto 0
            almacenLocal.setValue(name,0);
        }
        public void runPUSH_LOCAL_C(string name){ //podría recibir el almacen del contexto en caso de que se requiera
            //declara el elemento "name" en el almacen LOCAL con valor por defecto ''
            almacenLocal.setValue(name,' ');
        }
        public void runPUSH_GLOBAL_I(string name){
            //declara el elemento "name" en el almacen GLOBAL con valor por defecto 0
            almacenGlobal.setValue(name,0);
        }
        public void runPUSH_GLOBAL_C(string name){
            //declara el elemento "name" en el almacen GLOBAL con valor por defecto ''
            almacenLocal.setValue(name,' ');
        }
        public void runDEF(string name){
        }/* SI ALGUIEN SABE PORQUE DA ESTE ERROR CON ESTOS DOS MÉTODOS, FAVOR CORREGIR!!!
        public void runLOAD_CONST(int const){
            //carga en la pila el valor entero contenido en "const"
        }
        public void runLOAD_CONST(char const){
            //carga en la pila el valor char contenido en "const"
        }*/
        public void runLOAD_FAST(string varname){ //podría recibir el almacen del contexto en caso de que se requiera
            //busca en el almacén LOCAL el valor asociado a "varname" y lo inserta en la pila
            almacenLocal.getValue(varname); //EL GET VALUE DEBE DEVOLVER UN VALOR PARA PODERLO CARGAR A LA PILA
            //pilaExprs.push(val);
        }
        public void runSTORE_FAST(string varname){ //podría recibir el almacen del contexto en caso de que se requiera
            //almacena el contenido del tope de la pila en el almacén LOCAL para la variable "varname"
            dynamic tope=0;
            //tope == pilaExprs.pop(); //debe sacar el elemento de la pila y devolver su valor
            almacenLocal.setValue(varname,tope);
        }
        public void runSTORE_GLOBAL(string varname){
            //almacena el contenido del tope de la pila en el almacén GLOBAL para la variable "varname"
            dynamic tope=0;
            //tope == pilaExprs.pop(); //debe sacar el elemento de la pila y devolver su valor
            almacenLocal.setValue(varname,tope);
        }
        public void runLOAD_GLOBAL(string varname){
            //busca en el almacén GLOBAL el valor asociado a "varname" y lo inserta en la pila
            almacenGlobal.getValue(varname); //EL GET VALUE DEBE DEVOLVER UN VALOR PARA PODERLO CARGAR A LA PILA
            //pilaExprs.push(val);
        }
        public void runCALL_FUNCTION(int numparams){
            //lo referente a call function
        }
        public void runRETURN_VALUE(){
            //lo referente a return value
        }
        public void runEND(){
            //acaba la corrida y limpia/elimina las estructuras según sea el caso
        }
        public void runCOMPARE_OP(string op){
            //obtiene dos operandos de la pila, opera según el operador y finalmente inserta el resultados de la operación en la pila
            //se asume que los valores de los operandos son del mismo tipo, si no, se cae feo pero así debe ser... no hay mensajes de error
        }
        public void runBINARY_SUBSTRACT(){
            //obtiene dos operandos de la pila, opera según el operador y finalmente inserta el resultados de la operación en la pila
            //se asume que los valores son enteros, si no, se cae feo pero así debe ser... no hay mensajes de error
        }
        public void runBINARY_ADD(){
            //obtiene dos operandos de la pila, opera según el operador y finalmente inserta el resultados de la operación en la pila
            //se asume que los valores son enteros, si no, se cae feo pero así debe ser... no hay mensajes de error
        }
        public void runBINARY_MULTIPLY(){
            //obtiene dos operandos de la pila, opera según el operador y finalmente inserta el resultados de la operación en la pila
            //se asume que los valores son enteros, si no, se cae feo pero así debe ser... no hay mensajes de error
        }
        public void runBINARY_DIVIDE(){
            //obtiene dos operandos de la pila, opera según el operador y finalmente inserta el resultados de la operación en la pila
            //se asume que los valores son enteros, si no, se cae feo pero así debe ser... no hay mensajes de error
        }
        public void runBINARY_AND(){
            //obtiene dos operandos de la pila, opera según el operador y finalmente inserta el resultados de la operación en la pila
            //se asume que los valores son enteros, si no, se cae feo pero así debe ser... no hay mensajes de error
        }
        public void runBINARY_OR(){
            //obtiene dos operandos de la pila, opera según el operador y finalmente inserta el resultados de la operación en la pila
            //se asume que los valores son enteros, si no, se cae feo pero así debe ser... no hay mensajes de error
        }
        //PUEDE QUE ESTA NO SE OCUPE
        public void runBINARY_MODULO(){
            //obtiene dos operandos de la pila, opera según el operador y finalmente inserta el resultados de la operación en la pila
            //se asume que los valores son enteros, si no, se cae feo pero así debe ser... no hay mensajes de error
        }
        public void runJUMP_ABSOLUTE(int target){
            //cambia el indice de la línea actual en ejecución a la indicada por "target"
        }
        public void runJUMP_IF_TRUE(int target){
            //cambia el indice de la línea actual en ejecución a la indicada por "target" en caso de que el tope de la pila sea TRUE
        }
        public void runJUMP_IF_FALSE(int target){
            //cambia el indice de la línea actual en ejecución a la indicada por "target" en caso de que el tope de la pila sea FALSE
        }
        //método principal para correr todas las instrucciones de la lista
        public void run(){
            foreach(var inst in instSet){
                Console.WriteLine("Inst: {0}, Param: {1}", inst.Key, inst.Value);
                //debería llamarse a runXXXXX de cada instrucción para toda la lista en orden ascendente
            }
        }

        public void test(){
            addInst("PUSH_GLOBAL_I","n");
            addInst("PUSH_GLOBAL_C","res");
            addInst("LOAD_CONST",10);
            addInst("STORE_GLOBAL","n");
            addInst("LOAD_CONST",'a');
            addInst("STORE_GLOBAL","res");
        }
    }
}