using System;

namespace MyApplication
{

class arrayloop
{
	static void Main(string []arg)
	{

		string []name={"pavan","volve","fans","light"};

		for(int i=0;i<name.Length;i++)
		{
			Console.WriteLine(name[i]);
			Console.WriteLine(name[2]);

		}
	}
}
}