// See https://aka.ms/new-console-template for more information
using System;

class Program {
	static int demander_entier(){
		Console.WriteLine("Entrer un nombre :");
		int nb = -1;
		try {
			nb = Convert.ToInt32(Console.ReadLine());
		} catch (Exception e){
			Console.WriteLine(e.Message);
		}
		
		if (nb < 0){
			throw new ArgumentOutOfRangeException("Valeur invalide car négative");
		}
		return nb;
	}
	
	static void Main(){
		Console.WriteLine("Hello !!!");
		
		int nb = demander_entier();
		Console.WriteLine(nb);
	}
}