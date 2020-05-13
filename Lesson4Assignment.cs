//Lesson 4 assignment
//Author David Price

using System;

public class lesson4Assignment{
	public static void Main(){
		// Declare variables
		string strSideA, strSideB;
		double sideA, sideB;
		
		// Get input from the user
		Console.Out.Write("Enter Side A: ");
		strSideA = Console.ReadLine();
		sideA = Convert.ToDouble(strSideA);

		Console.Out.Write("Enter Side B: ");
		strSideB = Console.ReadLine();
		sideB = Convert.ToDouble(strSideB);

		// Calculate hypotenuse
		double result = Hypotenuse(sideA, sideB);

		// Display result
		Console.Out.WriteLine("The Hypotenuse is: " + result);
	}
	
	// Method calculates the hypotenuse as answer
	public static double Hypotenuse(double sideA, double sideB){
		double answer = Math.Sqrt(Math.Pow(sideA,2)+Math.Pow(sideB,2));
		return answer;
	}
}

		