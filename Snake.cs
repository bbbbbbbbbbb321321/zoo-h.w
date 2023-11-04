using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo_h.w
{
	class Snake : Reptile
	{
		private bool poisonous;

		public Snake(bool poisonous, int length, string name, int age, bool isPredator, int calories)
			: base(length, name, age, isPredator, calories)
		{
			this.poisonous = poisonous;
		}

		public bool Poisonous { get => poisonous; set => poisonous = value; }

		public override string ToString()
		{
			return $"poisonous = {poisonous} " + base.ToString();
		}
		//public string ToString()
		//{
		//	return "Object Snake poisonous=true";
		//}
	}
}
