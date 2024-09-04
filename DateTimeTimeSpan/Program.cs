using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
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
            Console.WriteLine("Uppgift 3: " + Uppgift3());
            Console.WriteLine("Uppgift 4: " + Uppgift4());
            Console.WriteLine("Uppgift 5: " + Uppgift5());
            Console.WriteLine("Uppgift 6: " + Uppgift6());
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

        public static string Uppgift3()
        {
            DateTime dt1 = new DateTime(2007, 3, 29);
            DateTime dt2 = DateTime.Now;

            return (dt1.Year + ((dt2.Year - dt1.Year) * 2)).ToString();
        }

        public static string Uppgift4()
        {
            DateTime dt1 = new DateTime(2022, 3, 26, 12, 0, 0);
            DateTime dt2 = new DateTime(2022, 3, 27, 12, 0, 0);

            TimeSpan ts = dt2 - dt1;

            return ts.TotalHours.ToString();

            // sommartid / vintertid
        }

        public static string Uppgift5()
        {
            DateTime dt1 = new DateTime(2023, 1, 1);
            DateTime dt2 = new DateTime(2024, 1, 1);
            DateTime dt3 = new DateTime(2025, 1, 1);

            TimeSpan ts1 = dt2 - dt1;
            TimeSpan ts2 = dt3 - dt2;

            return "[2023 - 2024]: " + ts1.TotalDays.ToString() + " [2024 - 2025]: " + ts2.TotalDays.ToString();

            // det var skottår, februari hade en extra dag
        }

        public static string Uppgift6()
        {
            DateTime dt1 = new DateTime(2015, 7, 1, 1, 59, 30);
            DateTime dt2 = new DateTime(2015, 7, 1, 2, 0, 30);

            TimeSpan timeSpan = dt2 - dt1;

            return timeSpan.TotalSeconds.ToString();

            // jag har ingen aning varför du ställer den här frågan
        }
    }
}
