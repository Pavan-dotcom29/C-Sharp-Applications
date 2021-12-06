using System;
namespace myapplication
{
	class sort
	{
		static void Main(string[] arg)
		{


			string[] name={"pavan","anup","neha","rohit"};
            Array.Sort(name);
			foreach(string i in name)
			{
				Console.WriteLine(i);
			}


			for(int k=0;k<name.Length;k++)
			{
				Console.WriteLine(name[k]);
			}


			int[] car={16,43,89,34,87};

			Array.Sort(car);
			
				foreach(int i in car)
				{
					Console.WriteLine(i);
				}

			
		}
	}
}