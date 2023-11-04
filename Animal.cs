using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo_h.w
{
	class Animal
	{
		private string name;
		private int age;
		private bool isPredator;
		private int calories;

		public Animal(string name, int age, bool isPredator, int calories)
		{
			this.name = name;
			this.age = age;
			this.isPredator = isPredator;
			this.calories = calories;
		}

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
		public bool IsPredator { get => isPredator; set => isPredator = value; }
		public int Calories { get => calories; set => calories = value; }
		public override string ToString()
		{
			return $"name = {name} age = {age}  ispredator = {isPredator}  calories ={calories}" ;
		}

	}
}
