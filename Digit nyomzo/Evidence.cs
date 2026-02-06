using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_nyomzo
{
	internal class Evidence
	{
		private int id;
		private string type;
		private string description;
		private int trust;

		public Evidence(int id, string type, string description, int trust)
		{
			this.id = id;
			this.type = type;
			this.description = description;
			this.trust = trust;
		}

		public int Id { get => id; set => id = value; }
		public string Type { get => type; set => type = value; }
		public string Description { get => description; set => description = value; }
		public int Trust { get => trust; set => trust = value; }

		public override string ToString()
		{
			return $"----------Vallomás-----------\n\t{this.id}:\n\t {this.type}\n\t{this.description}\n\t{this.trust}";
		}
	}
}
