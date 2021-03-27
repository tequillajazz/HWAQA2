using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWAQA2
{
	public class Rectangle
	{
		private double _rectangleArea;
		public double RectangleArea
		{
			get { return _rectangleArea; }
			set
			{
				_rectangleArea = value;
			}
		}

		public Rectangle(double rectangleArea)
		{
			RectangleArea = rectangleArea;
		}

		public double GetArea()
		{
			return Math.Pow(RectangleArea, 2);
		}
	}
}
