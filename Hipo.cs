using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo_h.w
{
	class Hipo : Mammal
	{
		private double fat;

		public Hipo(double fat, int month, int milk, string name, int age, bool isPredator, int calories)
			: base(month, milk, name, age, isPredator, calories)
		{
			this.Fat = fat;
		}

		public double Fat { get => fat; set => fat = value; }

		public override string ToString()
		{
			return $"fat = {fat} " + base.ToString();
		}
	}
}
