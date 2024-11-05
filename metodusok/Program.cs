namespace metodusok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Koszonto();
			Console.WriteLine(Osszeadas(10, 90));
			Console.ReadLine();
        }
		static void Koszonto()
		{
            Console.WriteLine("Hello világ!");
        }

		static int Osszeadas(int a, int b) 
		{
			/*
			int osszeg = a + b;
			return osszeg
			*/
			return a + b;
		}
	}
}
