using System;
using System.Collections.Generic;

namespace Programas
{
    class Fibonacci_S
    {
        static void Main(string[] args){

			Console.WriteLine("Secuencia Fibonacci");
			Console.WriteLine();
			
			foreach(int numero in Fibonacci(20)){
			
				Console.WriteLine(numero);
				
			}

        }
	
		public static IEnumerable<int> Fibonacci(int x){
			
    		int num1 = -1;
    		int num2 = 1;
			
    		for (int i = 0; i < x; i++){
				
       			int suma = num1 + num2;
       			num1 = num2;
       			num2 = suma;
       			yield return suma;
    		}
			
			yield break;
		}
    }
}
