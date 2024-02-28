using System;

namespace WorkingWithSpecificRowsColumns
{
	internal class WorkingWithSpecificRowsColumns
	{
		static void Main(string[] args)
		{
			int[,] matrix = new int[4, 4];

			Random random = new Random();
			int maxValue = 101;

			int sumSecondLine = 0;
			int productFirstColumn = 1;

			int secondLine = 1;
			int firstColumn = 0;

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = random.Next(maxValue);
				}
			}

			for (int i = 0; i < matrix.GetLength(1); i++)
			{
				sumSecondLine += matrix[secondLine, i];
			}

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				productFirstColumn *= matrix[i, firstColumn];
			}

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j] + "  ");
				}
				Console.WriteLine();
			}
			Console.WriteLine($"Сумма второй строки: {sumSecondLine}, произведение первого столбца: {productFirstColumn}");
		}
	}
}
