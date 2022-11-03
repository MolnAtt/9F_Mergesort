using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9F_Mergesort
{
	class Program
	{

		static void Mergesort(List<int> lista)
		{
			Mergesort(lista, 0, lista.Count - 1);
		}

		static void Mergesort(List<int> lista, int mettől, int meddig)
		{
			if (mettől<meddig)
			{
				int közepe = (mettől + meddig) / 2; // két elem esetén az első a "közepe"
				Mergesort(lista, mettől, közepe);
				Mergesort(lista, közepe+1, meddig);
				Összefésülés(lista, mettől, közepe, meddig);
			}
		}

		static void Összefésülés(List<int> lista, int mettől, int közepe, int meddig)
		{
			List<int> bal = new List<int>();
			List<int> jobb = new List<int>();


		}


		static void Main(string[] args)
		{
			List<int> lista = new List<int> { 4, 2, 8, 6, 0, 5, 1, 7, 3, 9 };

			Mergesort(lista);
		}
	}
}
