using System;
using System.Globalization;

namespace programmeDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;

            //Console.WriteLine(date);

            CultureInfo cultureFrançais = CultureInfo.GetCultureInfo("fr-FR");

            Console.WriteLine(date.ToString("dddd dd MMMM yyyy HH:mm:ss", cultureFrançais));

            DateTime dateDemain = date.AddDays(1);

            Console.WriteLine("Demain : " + dateDemain.ToString("dddd dd MMMM yyyy HH:mm:ss", cultureFrançais));

            var diff = dateDemain - date;
            Console.WriteLine("Différence heures : " + diff.TotalHours);

        }
    }
}
