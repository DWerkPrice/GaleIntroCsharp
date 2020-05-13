public class Lesson3AssignmentCarpetCostCalc{

	public static void Main(){
                //9 lines to enter length, width and cost/sq ft
		System.Console.Write("Enter the lenght of the Room: ");
		string lengthStr = System.Console.ReadLine();
		double length = System.Convert.ToDouble(lengthStr);

		System.Console.Write("Enter the width of the Room: ");
		string widthStr = System.Console.ReadLine();
		double width = System.Convert.ToDouble(widthStr);

		System.Console.Write("Enter the Cost/Square Foot of the carpet: ");
		string pricePerSqStStr = System.Console.ReadLine();
		double pricePerSqSt = System.Convert.ToDouble(pricePerSqStStr);

		//calculate area = length * width and display 
		double area = length * width;
		System.Console.WriteLine("The Area of the room is: " + area);
		
		//calculate cost = area * price per sq ft and display
		double cost = area * pricePerSqSt;
		System.Console.WriteLine("The cost to carpet the room is: $"+cost);
	}
}
		
		
		
		