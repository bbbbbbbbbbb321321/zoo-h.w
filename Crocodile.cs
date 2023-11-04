using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo_h.w
{
	class Crocodile:Reptile
	{
		private bool teeth;

		public Crocodile(bool teeth, int length, string name, int age, bool isPredator, int calories)
			:base(length, name, age, isPredator, calories)
		{
			this.teeth = teeth;
		}

		public bool Teeth { get => teeth; set => teeth = value; }
		public override string ToString()
		{
			return $"teeth = {teeth} " + base.ToString();
		}
	}
}
