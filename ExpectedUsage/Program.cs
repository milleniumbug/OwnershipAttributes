using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OwnershipAttributes;

namespace SampleUsage
{
	class Program
	{
		// unconditionally produces an object that needs disposing
		[return: Produces]
		public static Stream Producer()
		{
			return File.OpenRead(@"C:\windows\win.ini");
		}

		// conditionally consumes an object
		public static string Consumer([Consumes(Conditionally = "!leaveOpen")] Stream s, bool leaveOpen)
		{
			using(var reader = new StreamReader(s, Encoding.UTF8, true, 1024, leaveOpen))
			{
				return reader.ReadLine();
			}
		}

		static void Main(string[] args)
		{
			var s = Producer(); // external analyzer should warn
			Consumer(Producer(), false); // external analyzer shouldn't warn
			Consumer(Producer(), true); // external analyzer may warn (here's the condition's trivial, but generally this is Halting Problem)
		}
	}
}
