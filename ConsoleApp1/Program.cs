using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            /*
            WriteLine("введите первую дату");
            DateTime first = DateTime.Parse(ReadLine());
            WriteLine("введите вторую дату");
            DateTime second = DateTime.Parse(ReadLine());
            WriteLine($"{first:d} - {second:d} = {first.Subtract(second)}");
            */
            //2
            /*
            DateTime date = DateTime.Today;
            int daysLeft = DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
            Write($"До конца года осталось {daysLeft} дней" );
            */
            //1 практикум 2 задание(Запросить с клавиатуры возраст человека и вывести на экран следующее сообщение: Ты родился в .... году)
            /*
            Write("Введите дату рождения: ");
            DateTime d = DateTime.Parse(ReadLine());
            WriteLine($"ты родился в {d.Year} году");
            */
            // 1.3 (Определить возраст человека)
            /*
            Write("Введите дату рождения: ");
            DateTime d = DateTime.Parse(ReadLine());
            WriteLine($"Вам {DateTime.Now.Year - d.Year} лет");*/
            //2.3Ввести свою дату рождения. Определить:
            Write("Введите дату рождения: ");
            DateTime d = DateTime.Parse(ReadLine());
            WriteLine($"Вы родились в этот день недели: {d.DayOfWeek}");
            WriteLine($"Порядковый номер дня: {d.DayOfYear}");
            if (DateTime.IsLeapYear(d.Year))
            {
                Write("Вы родились в високосным году.");

            }
            else { Write("Вы родились в невисокосном году."); }
           // WriteLine($"Вам {d - }");
            
            //в классе описано 1 поле - фамилия и др. в программ показывает сколько лет.
            ReadKey();
        }
    }
}
