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
		public double CalculateDiameter()
		{
            //double diameter = Radius * 2;
            //return diameter;
            return Radius * 2;
        }
		public double CalculateCircumference()
		{
			//double circumference = 2 * Math.PI * Radius;
			//return circumference;
			return 2 * Math.PI * Radius;
        }
		public double CalculateArea()
		{
			//double area = Math.PI * Math.Pow(Radius, 2);
			//return area;
			return Math.PI * Math.Pow(Radius, 2);
        }
		public void Grow()
		{
			//Radius = Radius * 2;
			Radius *= 2;
		}
		public double GetRadius()
		{
			return Radius;
		}
	}
}

