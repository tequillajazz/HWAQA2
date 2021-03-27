using System;

namespace HWAQA2
{
	public class CompareCircleToRectangle
	{
		public void GetItemsAreaCompare()
		{
			Helper helper = new Helper();

			Console.WriteLine("Enter circle radius:");
			Circle circle = new Circle(helper.GetValueFromConsole());
			double circleArea = circle.GetArea();

			Console.WriteLine("Enter value for rectangle side:");
			Rectangle rectangle = new Rectangle(helper.GetValueFromConsole());
			double rectangleArea = rectangle.GetArea();

			if (ConditionsToFitItems.IfCircleFitToRectangle(circleArea, rectangleArea))
			{
				Console.WriteLine("Circle fit to rectangle.");
			}
			else if (ConditionsToFitItems.IfRectangleFitToCircle(circleArea, rectangleArea))
			{
				Console.WriteLine("Rectangle fit to circle.");
			}
			else { Console.WriteLine("Items mismatch."); }

			Console.WriteLine("Press any key...");
			Console.ReadKey();
			Console.Clear();
		}
	}
}
