using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
	internal class Human
	{
		string surname { get; set; }
		DateTime birthday { get; set; }
		public Human() { }
		public Human(string _surname, DateTime _birthday)
		{ 
		surname = _surname;
			birthday = _birthday;
		
		}
		public void PrintFullYears()
		{
			int age = DateTime.Now.Year - birthday.Year;
			if (DateTime.Now < birthday.AddYears(age)) age--;
			WriteLine($"Фамилия - {surname}, полных лет - {age}.");
		}
	}
}
