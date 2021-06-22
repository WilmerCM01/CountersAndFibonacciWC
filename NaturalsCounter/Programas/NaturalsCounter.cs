using System;
using System.Collections.Generic;

namespace Programas
{
    class NaturalsCounter
    {
        private static void Main(string[] args){

		Console.WriteLine("Contador de números naturales del 1 al 300");
		Console.WriteLine();
			
		foreach(int numero in NumerosNaturales(300)){
			
			Console.WriteLine(numero);
				
		}

      	}
	
	public static IEnumerable<int> NumerosNaturales(int maximo){
		
		for(int i = 1; i <= maximo; i++){
			
			yield return i;
				
		}
			
		yield break;
		
	}
    }
}
