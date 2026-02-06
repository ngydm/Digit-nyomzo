using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Digit_nyomzo
{
	internal class Felhasznalo
	{
		private string nev;
		private string azonosito;
		private string pozicio;

		public Felhasznalo(string nev, string azonosito, string pozicio)
		{
			this.nev = nev;
			this.azonosito = azonosito;
			this.pozicio = pozicio;
		}

		public string Nev { get => nev; set => nev = value; }
		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Pozicio { get => pozicio; set => pozicio = value; }


		public override string ToString()
		{
			return $"--------*Felhasználó fiok*---------\n\t{this.nev}:\n\t{this.azonosito}\n\t{this.pozicio}";
		}
	}
}
