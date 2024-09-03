using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTimeSpan
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("DateTime & TimeSpan: Svar till uppgifter:");
            Console.WriteLine("Uppgift 1: " + Uppgift1());
            Console.WriteLine("Uppgift 2: " + Uppgift2());
            // TODO uppg 3, 4 osv.
        }

        public static string Uppgift1()
        {
            DateTime dtnow = new DateTime(2022, 12, 06);
            DateTime dtthen = new DateTime(2009, 12, 18);
            TimeSpan dtdifference = dtnow - dtthen;

            return dtdifference.ToString();
        }

        public static string Uppgift2()
        {
            DateTime born = new DateTime(2007, 3, 29);
            DateTime now = DateTime.Now;

            TimeSpan ts = now - born;

            return ts.TotalDays.ToString() + " dagar, " + ts.TotalHours.ToString() + " timmar, " + ts.TotalMinutes.ToString() + " minuter";
        }
    }
}
