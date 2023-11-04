using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo_h.w
{
	class Bird : Animal
	{
		private int height;
		private int wing;

		public Bird(int height, int wing, string name, int age, bool isPredator, int calories) 
			: base(name, age, isPredator, calories)
		{
			this.height = height;
			this.wing = wing;
		}

		public int Height { get => height; set => height = value; }
		public int Wing { get => wing; set => wing = value; }
		public override string ToString()
		{
			return $"hight = {height} wing = {wing} " + base.ToString();
		}
	}
}
