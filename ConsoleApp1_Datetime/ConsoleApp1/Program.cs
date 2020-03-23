using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            var lastMonth = now.AddMonths(-1);
            var startMonth = lastMonth.AddDays(1 - lastMonth.Day); //上個月初
            var endMonth = startMonth.AddMonths(1).AddDays(-1);    //上個月底
            var thisMon = now.AddDays(1 - now.Day).Date;
            var eee = lastMonth.Day;
            var rrr = endMonth.ToShortDateString();
            var nextmonth = now.AddMonths(1);
            var NSMon = nextmonth.AddDays(1 - nextmonth.Day);
            var NEdMon = NSMon.AddMonths(1).AddDays(-1);

            var lastMonth1= now.AddMonths(-1);
            var startMonth1 = lastMonth.AddDays(1 - lastMonth.Day); //上個月初
            var endMonth1 = now.AddDays(1 - now.Day); //本月初

            DateTime GetFirstWorkDay(DateTime day)
            {
                //DateTime result = new DateTime(day);
                //while (result.DayOfWeek != day)
                //{
                //    result = result.AddDays(1);
                //}
                while(day.DayOfWeek.ToString()!=DayOfWeek.Sunday.ToString()&& day.DayOfWeek.ToString() != DayOfWeek.Saturday.ToString())
                {
                    day = day.AddDays(1);
                }

                return day;
            }
            Console.WriteLine(GetFirstWorkDay(endMonth1));
            Console.WriteLine(endMonth1);

             DateTime GetFirstDay(int year, int month, DayOfWeek day, int week)
            {
                DateTime result = new DateTime(year, month, 1);
                int i = 0;

                while (result.DayOfWeek != day || week != i)
                {
                    result = result.AddDays(1);
                    if ((result.DayOfWeek == day))
                        i++;
                }

                return result;
            }
            int week1 = 1;//第1周
            int week2 = 2;//第2周
            Console.WriteLine(GetFirstDay(2020,3,DayOfWeek.Monday,1));
            Console.WriteLine(GetFirstDay((int)now.Year,(int)now.Month,DayOfWeek.Monday, week1));
            Console.WriteLine(GetFirstDay((int)now.Year, (int)now.Month, DayOfWeek.Monday, week2));
            Console.WriteLine(GetFirstDay((int)nextmonth.Year, (int)nextmonth.Month, DayOfWeek.Monday, week1)+ " 下個月(nextmonth): " + nextmonth);


            int sum =0;
            for (int i = 0; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);

            

            Console.WriteLine("上個月  "+lastMonth1.Date.ToString());
            Console.WriteLine("上個月初 >= startMonth.Date " + startMonth1.Date.ToString());
            Console.WriteLine("本月初  < endMonth.Date " + endMonth1.Date.ToString());

            Console.WriteLine(lastMonth.ToString());
            Console.WriteLine(startMonth.ToString());
            Console.WriteLine(endMonth.ToString());
            Console.WriteLine("本月初 "+thisMon.ToString());
            Console.WriteLine(rrr.ToString());
            Console.WriteLine("------------");
            Console.WriteLine(nextmonth.ToString());
            Console.WriteLine(NSMon.ToString());
            Console.WriteLine(NEdMon.Date.ToString());
            Console.WriteLine("下個月初"+now.AddMonths(1).AddDays(1 - now.Day).ToString());
            Console.WriteLine(string.Format("{0:Y}", now));//2005年11
            Console.WriteLine("------------");          
            Console.ReadKey();
        }
    }
}
