using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 5, 9, 1, 19, 4, 6, 15, 8, 7, 2, 3 };
			foreach(int i in array)
			{
				Console.Write(i + " ");
			}

			Sort(array);
			Console.WriteLine();
			foreach(int i in array)
			{
				Console.Write(i + " ");
			}
		}

		static void Sort(int[] data)
		{
			int length = data.Length;
			for (int i = 0; i < length-1; i++)
			{
				for(int j = i; j < length; j++)
				{
					if(data[i] > data[j])
					{
						int temp = data[i];
						data[i] = data[j];
						data[j] = temp;
					}
				}
			}
		}
	}
}
