using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_nyomzo
{
	internal class Suspect
	{
		private Person person;
		private int suslvl;
		private string statusz;

		public Suspect(Person person, int suslvl, string statusz)
		{
			this.person = person;
			this.suslvl = suslvl;
			this.statusz = statusz;
		}

		public int Suslvl { get => suslvl; set => suslvl = value; }
		public string Statusz { get => statusz; set => statusz = value; }
		internal Person Person { get => person; set => person = value; }
	}
}
