using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo_h.w
{
	class Reptile :Animal
	{
		private int length;

		public Reptile(int length, string name, int age, bool isPredator, int calories):base(name, age, isPredator, calories)
		{
			this.Length = length;
		}

		public int Length { get => length; set => length = value; }
		public override string ToString()
		{
			return $"length = {length} " + base.ToString();
		}
	}
}
