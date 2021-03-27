using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWAQA2
{
	public class Circle
	{
		private double _radius;
		public double Radius
		{
			get { return _radius; }
			set
			{
				_radius = value;
			}
		}

		public Circle(double radius)
		{
			Radius = radius;
		}

		public double GetArea()
		{
			return Math.PI * Math.Pow(Radius, 2);
		}
	}
}
