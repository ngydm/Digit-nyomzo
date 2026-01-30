using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_nyomzo
{
	internal class Witness
	{
		private Person WPerson;
		private string confession;
		private DateOnly TimeoConfession;

		public Witness(Person wPerson, string confession, DateOnly timeoConfession)
		{
			WPerson = wPerson;
			this.confession = confession;
			TimeoConfession = timeoConfession;
		}

		public string Confession { get => confession; set => confession = value; }
		public DateOnly TimeoConfession1 { get => TimeoConfession; set => TimeoConfession = value; }
		internal Person WPerson1 { get => WPerson; set => WPerson = value; }
	}
}
