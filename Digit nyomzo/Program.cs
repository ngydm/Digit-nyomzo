namespace Digit_nyomzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Felhasznalo nyomzo1 = new Felhasznalo("Oláh Sándor","CIG007007","nyomzó");
			Ugy u = new Ugy(1, "bankrablas", "kiraboltak egy bankot", "aktiv");
			Ugy u2 = new Ugy(1, "gyújtogatás", "kiraboltak egy bankot", "aktiv");
			Person person1 = new Person("Hegedűs Gergő", 22, "közel lakik a bnakhoz");
            Person person2 = new Person("Balázs 'Goblin' Dávid", 19, "Gobma bányász sok aranya van");
			Suspect suspect1 = new Suspect(person1, 87, "Örizetben");
			Witness confession1 = new Witness(person2, "Láttam ahogy Hegedűs Gergő sietve távozik a bankbol a büntény napján", 2008, 4, 5);
			Evidence e = new Evidence(1, "simaszk", "A bank melleti szemetesben találtunk egy simaszkot dns vizságalot végzetünk el rajta", 4);
			Evidence e2 = new Evidence(2, "pisztoly", "A bank melleti szemetesben találtunk egy simaszkot dns vizságalot végzetünk el rajta", 4);
			Timeline point1 = new Timeline(u,"A bankrablás napja", 208, 04, 02);
			List<Ugy> ugyek = new List<Ugy>();
			ugyek.Add(u);
			ugyek.Add(u2);
			u.BizonyitekHozzaadasa(e);
			u.BizonyitekHozzaadasa(e2);
			u.FelhasznaloHozzaadasa(nyomzo1);

            u.FelhasznaloHozzaadasa(nyomzo1);
            u.BizonyitekHozzaadasa(e);
			Console.WriteLine(nyomzo1);
			Console.WriteLine($"\t{person1}");
			Console.WriteLine(suspect1);
			Console.WriteLine($"\t{person2}");
			Console.WriteLine(confession1);

			Database s = new Database(ugyek);
			Console.WriteLine(s);
			s.Ugyek[0].Allapot = "lezárt";
			Console.WriteLine("-----------adas-------");
			Console.WriteLine(s);
        }
    }
}
