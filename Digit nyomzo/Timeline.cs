using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_nyomzo
{
	internal class Timeline
	{
		private Ugy ugyazonosito;
		private string description;
		private int year;
		private int month;
		private int day;

		public Timeline(Ugy ugyazonosito, string description, int year, int month, int day)
		{
			this.ugyazonosito = ugyazonosito;
			this.description = description;
			this.year = year;
			this.month = month;
			this.day = day;
		}

		public string Description { get => description; set => description = value; }
		public int Year { get => year; set => year = value; }
		public int Month { get => month; set => month = value; }
		public int Day { get => day; set => day = value; }
		internal Ugy Ugyazonosito { get => ugyazonosito; set => ugyazonosito = value; }

		public override string ToString()
		{
			return $"\tIdővonal{this.ugyazonosito}-{this.description}-{this.year}.{this.month}.{this.day}";
		}
	}
}
