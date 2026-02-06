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
		private int year;
		private int month;
		private int day;


		public Witness(Person wPerson, string confession, int year, int month, int day)
		{
			WPerson = wPerson;
			this.confession = confession;
			this.year = year;
			this.month = month;
			this.day = day;
		}

		public string Confession { get => confession; set => confession = value; }
		public int Year { get => year; set => year = value; }
		public int Month { get => month; set => month = value; }
		public int Day { get => day; set => day = value; }
		internal Person WPerson1 { get => WPerson; set => WPerson = value; }

		public override string ToString()
		{
			return $"----------Vallomás-----------\n\t{this.WPerson}:\n\t vallomása:\n\t {this.confession}\n\t{this.year}.{this.month}.{this.day}";
		}
	}
}
