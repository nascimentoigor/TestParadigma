//Rextester.Program.Main is the entry point for your code. Don't change it.
//Microsoft (R) Visual C# Compiler version 2.9.0.63208 (958f2354)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            int soma = new int();
            int valorAleatorio1 = new int();
            int valorAleatorio2 = new int();
            List<int> x = new List<int>() {2, 7, 11, 15};
            
            for(int i = 0; i < 2; i++){
                valorAleatorio1 = retornaValorAleatorio(x, 0);
                if(soma == valorAleatorio1){
                    valorAleatorio1 = retornaValorAleatorio(x, soma);
                    soma += valorAleatorio1;
                }
                else{
                    soma += valorAleatorio1;
                }
            }
            Console.WriteLine("Soma da entrada: " + soma);
            valorAleatorio2 = soma - valorAleatorio1;
            Console.WriteLine(soma + " é a soma de " + valorAleatorio1 + " + " + valorAleatorio2);
            
        }
        
        public static int retornaValorAleatorio(List<int> x, int tiraValor)
        {
            int valorAleatorio = new int();
            var rnd = new Random(DateTime.Now.Millisecond);
            valorAleatorio = x[rnd.Next(x.Count)];
            if(valorAleatorio != tiraValor){
                return valorAleatorio;
            }
            else {
                valorAleatorio = retornaValorAleatorio(x, tiraValor);
                return valorAleatorio;
            }
            
        }
    }
}