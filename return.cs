using Sysytem;
namespace appliaction
{
	class return
	{
		static void call(int x)
		{
			return x+5;
		}
		static void Main(string[] args)
		{
           Console.WriteLine(call(3));
		}
	}
}