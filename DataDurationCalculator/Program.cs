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

		private static void GetDates()
		{
			Console.WriteLine("Please enter two dates: ");

			Console.Write("Date 1: ");
			date1 = DateTime.Parse(Console.ReadLine());

			Console.Write("Date 2: ");
			date2 = DateTime.Parse(Console.ReadLine());

			CalculateDifferenceInDates(date1, date2);
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
			Console.WriteLine(string.Format("The time difference between {0} and {1} is {2} days - {3} hours - {4} minutes."), date1, date2, totalDays, totalHours, totalMinutes);
		}
	}
}
