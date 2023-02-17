using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EY_Day_2
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] arr = { 'a', 'e', 'i', 'o', 'u' };
			String s1 =  new String(arr);
			string s2 = "Welcome to C#";
			Console.WriteLine(s1);
			Console.WriteLine(s2);
			StringBuilder addword = new StringBuilder("Spiderman");
			addword.Append(", Superman");
			addword.Append(",Batman");
			Console.WriteLine(addword);

			Console.ReadLine();
		}
	}
}
