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
            int i;
            int j;
            int?[] x = {7, 5, 3, 9, 6, 4, 1};
            
            for(i=0;i<=x.Length;i++){
                if(x[i] == 9){
                    x[i] = 5;
                }
                if(x[i] == 4){
                    for(j = i; j<x.Length-1; j++){
                        x[j] = x[j+1];
                    }
                    x[x.Length-1] = null;
                }                             
                Console.WriteLine(x[i]);  
            }
        }
    }
}