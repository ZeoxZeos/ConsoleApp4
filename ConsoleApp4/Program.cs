using System;
using System.Dynamic;

namespace ConsoleApp4
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var myInherit = new MyInhering() { LocalStr = "DO DUPY", mybaseInt = 11111 };
			Console.WriteLine($"{myInherit.mybaseInt}: ---Hello World! --- {myInherit.LocalStr}");
			Console.ReadLine();
		}
	}

	public class MyBase
	{
		public int mybaseInt { get; set; }
	}

	public class MyInhering : MyBase
	{
		public string LocalStr { get; set; }
	}
}