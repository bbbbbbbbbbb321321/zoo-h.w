using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo_h.w
{
	class Bird:Animal
	{
		private int hight;
		private int wing;

		public Bird(int hight, int wing, string name, int age, bool isPredator, int calories):base(name, age, isPredator, calories)
		{
			this.hight = hight;
			this.wing = wing;
		}

		public int Hight { get => hight; set => hight = value; }
		public int Wing { get => wing; set => wing = value; }
		public override string ToString()
		{
			return $"hight = {hight} wing = {wing} " +base.ToString();
		}
	}
}
