using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDurationCalculator
{
	class Program
	{
		public static DateTime date1;
		public static DateTime date2;

		static void Main(string[] args)
		{
			GetDates();
		}

		private static void QuitConsoleApp()
		{
			Console.WriteLine("\n\nPress R to repeat or any other key to exit the app.");
			ConsoleKeyInfo quitKey = Console.ReadKey();

			if (quitKey.Key.ToString().ToLower() == "r")
			{
				Console.Clear();
				GetDates();
			}
		}

		private static void GetDates()
		{
			Console.WriteLine("Please enter two dates: ");

			Console.Write("Date 1: ");
			if (!DateTime.TryParse(Console.ReadLine(), out date1))
				InvalidDate(); 

			Console.Write("Date 2: ");
			if (!DateTime.TryParse(Console.ReadLine(), out date2))
				InvalidDate();

			CalculateDifferenceInDates(date1, date2);
		}

		private static void InvalidDate()
		{
			Console.Clear();
			Console.WriteLine(string.Format("You entered in an invalid date. Please use an acceptable date format like 1-1-18 or 1/1/18 \n\n"));
			GetDates();
			
		}

		private static void CalculateDifferenceInDates(DateTime date1, DateTime date2)
		{
			double totalMinutes;
			double totalHours;
			double totalDays;

			totalMinutes = (FindTheBiggerDate(date1, date2)).TotalMinutes;
			totalHours = totalMinutes / 60;
			totalDays = totalHours / 24;

			BuildAnswer(date1, date2, totalDays, totalHours, totalMinutes);
		}

		private static TimeSpan FindTheBiggerDate(DateTime date1, DateTime date2)
		{
			if (date1 < date2)
				return (date2 - date1);
			else 
				return (date1 - date2);
		}

		private static void BuildAnswer(DateTime date1, DateTime date2, double totalDays, double totalHours, double totalMinutes)
		{
			Console.WriteLine(string.Format("The time difference between {0} and {1} is {2} days - {3} hours - {4} minutes.", date1.ToString("d"), date2.ToString("d"), totalDays, totalHours, totalMinutes));
			QuitConsoleApp();
		}
	}
}
