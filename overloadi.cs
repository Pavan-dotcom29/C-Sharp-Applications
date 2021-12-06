using System;
namespace appliaction
{
	class overloadi
	{
		static int my(int x)
		{
			return x+5;

		}
		static double my1(int y)
		{
			return y+6;
		}
    	static void Main(string [] args)
		{
			int name=my(3);
			Console.WriteLine(name);

		  double name1=my1(345);
		  Console.WriteLine(name1);
		}
	}
}