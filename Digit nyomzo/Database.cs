using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_nyomzo
{
	internal class Database
	{
		private List<Ugy> ugyek;

		public Database(List<Ugy> ugyek)
		{
			this.ugyek = ugyek;
		}

		internal List<Ugy> Ugyek { get => ugyek; set => ugyek = value; }

		public override string ToString()
		{ string s = " ";
			foreach (Ugy ugy in ugyek) 
			{
				s += ugy.ToString();
			}
			return s;
		}

	}
}
