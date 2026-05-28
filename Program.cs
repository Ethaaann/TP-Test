// See https://aka.ms/new-console-template for more information
using System;

class Program {
	static int demander_entier(){
		Console.WriteLine("Saisir un entier");
		int nb = -1;
		try {
			nb = Convert.ToInt32(Console.ReadLine());
		} catch (Exception e){
			Console.WriteLine(e.Message);
		}
		
		if (nb < 0){
			throw new ArgumentOutOfRangeException("L'entier doit être strictement positif (Parameter 'n')");
		}
		return nb;
	}
	
	static double wotan(int a){
		double res = 0.0;
		for (double i = 1; i <= a; i++){
			res = res + Convert.ToDouble(1/i);
		}
		return res;
	}
	
	static void Main(){		
		int nb = demander_entier();
		double res = wotan(nb);
		res = Math.Round(res, 2);
		Console.WriteLine($"W{nb} vaut {res}");
	}
}