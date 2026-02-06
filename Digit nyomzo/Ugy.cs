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
		private List<Evidence> bizonyitékok;

		public Ugy(int azonosito, string cim, string leiras, string allapot)
		{
			this.azonosito = azonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.felhasznalok = new List<Felhasznalo>();
			this.bizonyitékok = new List<Evidence>();
		}

		public int Azonosito { get => azonosito; set => azonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		public List<Evidence> Bizonyitékok { get => bizonyitékok; set => bizonyitékok = value; }
		internal List<Felhasznalo> Felhasznalok { get => felhasznalok; set => felhasznalok = value; }

		public void FelhasznaloHozzaadasa(Felhasznalo f)
		{
			felhasznalok.Add(f);
		}

		public void BizonyitekHozzaadasa(Evidence f)
		{
			bizonyitékok.Add(f);
		}


		public void CaseStatus(string ujallapot) 
		{
			this.Allapot = ujallapot;
		}

		public override string ToString()
		{
			return $"{this.azonosito}-{this.cim}-{this.leiras}-{this.allapot}-{this.Bizonyitékok}-{this.felhasznalok}";
		}
	}
}
