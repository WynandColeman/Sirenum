using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate Data            
            List<shift> shifts = new List<shift>();
            shifts.Add(new shift { start = DateTime.Parse("2020-06-23 09:00"), end = DateTime.Parse("2020-06-23 17:00"), workerId = "John" });
            shifts.Add(new shift { start = DateTime.Parse("2020-06-23 06:00"), end = DateTime.Parse("2020-06-23 14:00"), workerId = "John" });
            shifts.Add(new shift { start = DateTime.Parse("2020-06-23 11:30"), end = DateTime.Parse("2020-06-23 18:00"), workerId = "Emma" });
            shifts.Add(new shift { start = DateTime.Parse("2020-06-23 09:00"), end = DateTime.Parse("2020-06-23 17:00"), workerId = "John" });
            shifts.Add(new shift { start = DateTime.Parse("2020-06-23 09:00"), end = DateTime.Parse("2020-06-23 17:00"), workerId = "John" });

            List<payrate> payrate = new List<payrate>();
            payrate.Add(new payrate { hourlyRate = decimal.Parse("15.00"), name = "Morning", timeOfDayStart = DateTime.Parse("05:00"), timeOfDayEnd = DateTime.Parse("10:00") });
            payrate.Add(new payrate { hourlyRate = decimal.Parse("18.00"), name = "Evening", timeOfDayStart = DateTime.Parse("16:30"), timeOfDayEnd = DateTime.Parse("20:00") });
            payrate.Add(new payrate { hourlyRate = decimal.Parse("20.00"), name = "Night", timeOfDayStart = DateTime.Parse("20:00"), timeOfDayEnd = DateTime.Parse("23:00") });
            payrate.Add(new payrate { hourlyRate = decimal.Parse("15.00"), name = "Default", timeOfDayStart = DateTime.Parse("05:00"), timeOfDayEnd = DateTime.Parse("10:00") });
            payrate.Add(new payrate { });

            List<result> result = new List<result>();            
                foreach (var shift in shifts)
                {
                    foreach (var rate in payrate)
                    {


                    if (shift.start<
                    {

                    }
                    }
                }
           
            resultsBreakdown();

            void resultsBreakdown()
            {
                Console.WriteLine("Shifts");
                foreach (var shift in shifts)
                {
                    Console.WriteLine(shift.workerId + " " + shift.start + " " + shift.end);

                }
                Console.WriteLine("\nPay Rates");
                foreach (var rate in payrate)
                {
                    Console.WriteLine(rate.name + " " + "£" + rate.hourlyRate + " " + rate.timeOfDayStart + " " + rate.timeOfDayEnd);
                }

                Console.WriteLine("\nPay breakdown results (worker, rate name, total work, total pay)");
                foreach (var r in result)
                {
                    Console.WriteLine(r.shift.workerId);
                }

            }
            //TimeSpan totalWork(result)
            //{
            //    TimeSpan total;
            //    foreach (var r in result)
            //    {

            //        total = r.shift.end - r.shift.start;
            //    }

            //}
            void TotalPay(shift shift, payrate payrate)
            {
            //    string total = "";
            //    if (shift.start.ToString("hh:mm") < payrate.timeOfDayStart)
            //    {
            //        total = TimeSpan.Parse(shift.start.ToString("hh:mm")).ToString() + payrate.timeOfDayStart.ToString();
            //    }
            //    return total;
            }
        }
                
    }
}
