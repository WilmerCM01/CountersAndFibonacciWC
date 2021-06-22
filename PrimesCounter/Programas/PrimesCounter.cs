using System;
using System.Collections.Generic;

namespace Programas
{
    class PrimesCounter
    {
        static void Main(string[] args){

		Console.WriteLine("Contador de números primos");
		Console.WriteLine();
			
		foreach(int numero in Primos(100)){
			
			Console.WriteLine(numero);
				
		}

       	}
	
	public static IEnumerable<int> Primos(int x){
			
		Boolean verificador = true;
		int a, b;
			
        	for (a = 2; a <= x; a++){
				
            		for (b = 2; b <= x; b++){
					
                		if (a != b && a % b == 0){
						
                    			verificador = false;
                    			break;
				}  
           		 }
				
			if(verificador){
			
				yield return a;
				
			}
				
			verificador = true;
		}
			
		yield break;
	}
    }
}
