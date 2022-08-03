using System;

namespace task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = {63,35,29,45,87,12,96,5};
			int small = 0; int i = 0;
			
			for (i = 0; i < ages.Length; i++)
			{
				small = ages[0];
			}

			for (i = 1; i < ages.Length; i++)
			{
		
				if (small > ages[i])
					small = ages[i];
			}

			Console.WriteLine(small);

		}
    }
}
