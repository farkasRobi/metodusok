using System.Reflection.Metadata.Ecma335;

namespace metodusok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Koszonto();
			Console.WriteLine(Osszeadas(10, 90));
			int a = 5;
            Console.WriteLine(Duplaz(a));
			int duplazott = Duplaz(a);
            Console.WriteLine(a);
            Console.WriteLine(duplazott);
            Console.WriteLine(Osszeg(10));
			int elso = 5;
			int masodik = 10;
			Csere(ref elso, ref masodik);
            Console.WriteLine(elso + " " + masodik);
			List<int> primSzamok = Primszamok(1, 1000);
			string szoveg = "Jó ez az óra, de nem ez a kedvencem";
			int darab = SzovegElofordulas(szoveg, "ez");
            Console.WriteLine($"Ennyiszer szerepel az ez szó a szövegben: {darab}");
            foreach (int szam in primSzamok)
			{
                Console.Write(szam + ",");
            }
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

		static int Duplaz(int szam)
		{
			return szam = szam * 2;
		}

		static int Osszeg(int a, int b = 5, int c = 2)
		{
			return a + b + c;
		}

		static void Csere(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b=temp;
            Console.WriteLine(a + "" + b);
        }

		static List<int> Primszamok(int kezdo, int veg)
		{
			List<int> primLista = new List<int>();
			for (int i = kezdo; i < veg; i++)
			{
				if (primE(i))
					primLista.Add(i);
			}
			return primLista;
		}

		static bool primE(int szam)
		{
			if (szam < 2) return false;
			for (int i = 2; i <= Math.Sqrt(szam); i++)
			{
				if (szam % i == 0) return false;
			}
			return true;
		}

		static int SzovegElofordulas(string szoveg, string alSzoveg)
		{
			int szam = 0;
			int index = szoveg.IndexOf(alSzoveg);
			while (index != -1)
			{
				szam++;
				index = szoveg.IndexOf(alSzoveg, index + 1);
			}
			return szam;
		}
	}
}
 