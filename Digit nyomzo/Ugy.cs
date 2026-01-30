using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_nyomzo
{
	internal class Ugy
	{
		private int azonosito;
		private string cim;
		private string leiras;
		private string allapot;
		List<Felhasznalo> felhasznalok;
		private List<string> bizonyitékok;

		public Ugy(int azonosito, string cim, string leiras, string allapot, List<Felhasznalo> felhasznalok, List<string> bizonyitékok)
		{
			this.azonosito = azonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.felhasznalok = felhasznalok;
			this.bizonyitékok = bizonyitékok;
		}

		public int Azonosito { get => azonosito; set => azonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		public List<string> Bizonyitékok { get => bizonyitékok; set => bizonyitékok = value; }
		internal List<Felhasznalo> Felhasznalok { get => felhasznalok; set => felhasznalok = value; }


	}
}
