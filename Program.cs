using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo_h.w
{
	class Program
	{
		static void Main(string[] args)
		{
			Snake snake1 = new Snake(true, 1, "1", 1, true, 1);
			Console.WriteLine(snake1.ToString());
			Bird bird1 = new Bird(1, 1, "1", 1, true, 1);
			Console.WriteLine(bird1.ToString());
		}
	}
}
