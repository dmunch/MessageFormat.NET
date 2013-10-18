using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageFormat.NET
{	
	class Program
	{
		static void Main(string[] args)
		{
			string t1 = "test10 {0} {0} {1}";
			string t2 = "test10 {a} {b} {c}";
			string t3 = "text blabla {0,date} text {1,time, long} t {0 } {bla1} {siegfried}";
			string t4 = "{days, plural , =0 {aucune} one {heure} other {heures}}";
			
			Console.WriteLine(MessageFormat.Format(t1, DateTime.Now, 1, 2));

			var dict = new Dictionary<string, object>();
			dict.Add("a", DateTime.Now);
			dict.Add("b", 1.32);
			dict.Add("c", "siggi");			
			Console.WriteLine(MessageFormat.Format(t2, dict));

			Console.ReadLine();
		}
	}
}
