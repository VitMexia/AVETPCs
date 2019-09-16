using System;

public class App{
	
	public static void Main(String []arg){
		Foo(12);
		Foo(19);
	}
	
	private static void Foo(int nr){
		
		Console.WriteLine(nr);
		Console.WriteLine(", ");
		
		if(nr == 1){
			Console.WriteLine();
			return;
		}
		
		if(nr%2 != 0){
			Foo(nr*3+1);
			return;
		}
		
		Foo(nr/2);
		return;
	}
	
}