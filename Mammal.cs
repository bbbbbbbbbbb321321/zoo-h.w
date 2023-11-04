using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo_h.w
{
	class Mammal : Animal
	{
		private int month;
		private int milk;

		public Mammal(int month, int milk, string name, int age, bool isPredator, int calories)
			:base(name, age, isPredator, calories)
		{
			this.month = month;
			this.milk = milk;
		}

		public int Month { get => month; set => month = value; }
		public int Milk { get => milk; set => milk = value; }
		public override string ToString()
		{
			return $"month = {month} milk ={milk} " + base.ToString();
		}
	}
}
