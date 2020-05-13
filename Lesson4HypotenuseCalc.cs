using System;

public class lesson4Assignment{
	public static void Main(){
		string strSideA, strSideB;
		int sideA, sideB;

		Console.Out.Write("Enter Side A: ");
		strSideA = Console.ReadLine();
		sideA = Convert.ToDouble(strSideA);

		Console.Out.Write("Enter Side B: ");
		strSideB = Console.ReadLine();
		sideB = Convert.ToDouble(strSideB);

		result = Hypotenuse(sideA, sideB);

		Console.Out.WriteLine("The Hypotenuse is: " + result);
	}

	public static double Hypotenuse(double sideA, double sideB){
		double answer = Math.Sqrt(Math.Pow(sideA,2)+Math.Pow(sideB,2));
		return answer;
	}
}

		