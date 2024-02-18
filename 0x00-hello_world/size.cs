using System;

namespace TypeSizes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"size of char: {sizeof(char)} byte(s)");
			Console.WriteLine($"size of int: {sizeof(int)} byte(s)");
			Console.WriteLine($"size of long: {sizeof(long)} byte(s)");
			Console.WriteLine($"size of float: {sizeof(float)} byte(s)");
			Console.WriteLine($"size of double: {sizeof(double)} byte(s)");
			Console.WriteLine($"size of decimal: {sizeof(decimal)} byte(s)");
		}
	}	
}
