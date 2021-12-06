using System;
namespace application
{
	class methodparamter 
	{
		static void call(string name,int age)
		{
			Console.WriteLine(name +" "+ age);
		}


		static void Main(string[] args)
		{
			call("pabvan",324);
			call("werf",3);
			call("dfh",3345);
			call("pabvan",3245);


		}
	}
}