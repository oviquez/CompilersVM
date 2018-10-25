using System;
using System.Collections.Generic;

namespace InstructionsNameSpace{
    class InstructionSet
    {   
        private LinkedList<KeyValuePair<string, dynamic>> instSet {get; set;} 
        public InstructionSet(){
            instSet = new LinkedList<KeyValuePair<string,dynamic>>() ;
            test();
        }

        public void addInst(string inst, dynamic param){
            instSet.AddLast(new KeyValuePair<string, dynamic>(inst,param));
        }

        public void runPUSH_LOCAL_I(string name){
            
        }
        public void runPUSH_LOCAL_C(string name){
        }
        public void runPUSH_GLOBAL_I(string name){
        }
        public void runPUSH_GLOBAL_C(string name){
        }
        public void runDEF(string name){
        }/* SI ALGUIEN SABE PORQUE DA ESTE ERROR CON ESTOS DOS MÉTODOS, FAVOR CORREGIR!!!
        public void runLOAD_CONST(int const){
        }
        public void runLOAD_CONST(char const){
        }*/
        public void runLOAD_FAST(string varname){
        }
        public void runSTORE_FAST(string varname){
        }
        public void runSTORE_GLOBAL(string varname){
        }
        public void runLOAD_GLOBAL(string name){
        }
        public void runCALL_FUNCTION(int numparams){
        }
        public void runRETURN_VALUE(){
        }
        public void runEND(){
        }
        public void runCOMPARE_OP(string op){
        }
        public void runBINARY_SUBSTRACT(){
        }
        public void runBINARY_ADD(){
        }
        public void runBINARY_MULTIPLY(){
        }
        public void runBINARY_DIVIDE(){
        }
        public void runBINARY_AND(){
        }
        public void runBINARY_OR(){
        }
        //PUEDE QUE ESTA NO SE OCUPE
        public void runBINARY_MODULO(){
        }
        public void runJUMP_ABSOLUTE(string target){
        }
        public void runJUMP_IF_TRUE(string target){
        }
        public void runJUMP_IF_FALSE(string target){
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