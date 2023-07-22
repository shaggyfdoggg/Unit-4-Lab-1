using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
	internal class Circle
	{
		//Properties
		private double Radius { get; set; }

		//Constructor
		public Circle(double _radius)
		{
			Radius = _radius;
		}
		//Methods
		public double CalculateDiameter(double diameter)
		{
			diameter = Radius * 2;
			return diameter;
		}
		public double CalculateCircumference(double circumference)
		{
			circumference = 2 * Math.PI * Radius;
			return circumference;
		}
		public double CalculateArea(double area)
		{
			area = Math.PI * Radius * Radius;
			return area;
		}
		public void Grow()
		{
			Radius = Radius * 2;
		}
		public double GetRadius()
		{
			return Radius;
		}
	}
}

