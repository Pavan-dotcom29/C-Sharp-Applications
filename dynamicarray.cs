using System;

namespace myapplication
{
	class dynamicarray
	{
		static void Main(string[] args)
		{
			string[] name;

			name=new string[]{"pavan","anup","mohit"};
			Console.WriteLine(name[0]);


			string[] num=new string[4] {"pavan","neha","mohit","reew"};
			Console.WriteLine(num[3]);
			Console.WriteLine(num[2]);
			Console.WriteLine(num[1]);
			Console.WriteLine(num[0]);




		}
	}
}