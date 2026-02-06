namespace Digit_nyomzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Felhasznalo nyomzo1 = new Felhasznalo("Oláh Sándor","CIG007007","nyomzó");
            Person person1 = new Person("Hegedűs Gergő", 22, "közel lakik a bnakhoz");
            Person person2 = new Person("Balázs 'Goblin' Dávid", 19, "Gobma bányász sok aranya van");
            Evidence e = new Evidence(1, "labnyom", "", 1);
            Ugy u = new Ugy(1, "bankrablas", "kiraboltak egy bankot", "aktiv");
            Suspect suspect1 = new Suspect(person1, 87, "Örizetben");
            Witness confession1 = new Witness(person2, "Láttam ahogy Hegedűs Gergő sietve távozik a bankbol a büntény napján", 2008,4,5);
            u.FelhasznaloHozzaadasa(nyomzo1);
            u.BizonyitekHozzaadasa(e);
			Console.WriteLine(nyomzo1);
			Console.WriteLine($"\t{person1}");
			Console.WriteLine(suspect1);
			Console.WriteLine($"\t{person2}");
			Console.WriteLine(confession1);
        }
    }
}
