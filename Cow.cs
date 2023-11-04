using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo_h.w
{
	class Cow:Mammal
	{
		private int birthNum;

		

		public Cow(int birthNum, int month, int milk, string name, int age, bool isPredator, int calories):base(month, milk, name, age, isPredator, calories)
		{
			this.BirthNum = birthNum;
		}

		public int BirthNum { get => birthNum; set => birthNum = value; }
		public override string ToString()
		{
			return $"birthNum = {birthNum} " + base.ToString();
		}
	}
}
