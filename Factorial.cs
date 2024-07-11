using System;

class Factorial{
	public static void Main(String [] args){
		int myNumber;	
		Console.WriteLine("Enter your Number");
		myNumber = Convert.ToInt32(Console.ReadLine());
		int factorial=1;
		if(myNumber==0 || myNumber ==1){
			Console.WriteLine(1);
		}
		else{
			while(myNumber>0){
				factorial = factorial * myNumber;
				myNumber--;
			}
		}
		Console.WriteLine("The factorial is "+factorial);

	}
}