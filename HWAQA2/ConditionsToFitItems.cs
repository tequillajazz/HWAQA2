using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWAQA2
{
	public class ConditionsToFitItems
	{
		public static bool IfCircleFitToRectangle(double circleArea, double rectangleArea)
		{
			return Math.Sqrt(rectangleArea) >= 2 * (Math.Sqrt(circleArea / Math.PI));
		}

		public static bool IfRectangleFitToCircle(double circleArea, double rectangleArea)
		{
			return Math.Sqrt(rectangleArea) <= (Math.Sqrt(circleArea / Math.PI)) * Math.Sqrt(2);
		}
	}
}
