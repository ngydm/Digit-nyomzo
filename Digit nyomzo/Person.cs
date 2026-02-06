using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_nyomzo
{
	internal class Person
	{
		private string name;
		private int age;
		private string note;

		public Person(string name, int age, string note)
		{
			this.name = name;
			this.age = age;
			this.note = note;
		}

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
		public string Note { get => note; set => note = value; }

		public override string ToString()
		{
			return $"--( személyes adatok )--\n\t{this.name}:\n\t{this.Age}\n\t{this.Note}";
		}

	}

}
