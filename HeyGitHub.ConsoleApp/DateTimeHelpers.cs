//using System.Globalization;

namespace HeyGitHub.ConsoleApp
{
    internal class DateTimeHelpers
    {
        public string GetPersianDayOfWeekName(DateTime dateTime)
        {
            //var persianCalendar = new PersianCalendar();
            //var dayOfWeek = persianCalendar.GetDayOfWeek(dateTime);
            var dayOfWeekName = "";
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dayOfWeekName = "1shanbe";
                    break;
                case DayOfWeek.Monday:
                    dayOfWeekName = "2shanbe";
                    break;
                case DayOfWeek.Tuesday:
                    dayOfWeekName = "3shanbe";
                    break;
                case DayOfWeek.Wednesday:
                    dayOfWeekName = "4hanbe";
                    break;
                case DayOfWeek.Thursday:
                    dayOfWeekName = "5shanbe";
                    break;
                case DayOfWeek.Friday:
                    dayOfWeekName = "Jome";
                    break;
                case DayOfWeek.Saturday:
                    dayOfWeekName = "Shanbe";
                    break;
            }
            return dayOfWeekName;
        }

        public System.ConsoleColor GetDayOfWeekColor(DateTime dateTime)
        {
            System.ConsoleColor dayOfWeekColor = ConsoleColor.White;
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dayOfWeekColor = ConsoleColor.Green;
                    break;
                case DayOfWeek.Monday:
                    dayOfWeekColor = ConsoleColor.Green;
                    break;
                case DayOfWeek.Tuesday:
                    dayOfWeekColor = ConsoleColor.Green;
                    break;
                case DayOfWeek.Wednesday:
                    dayOfWeekColor = ConsoleColor.Green;
                    break;
                case DayOfWeek.Thursday:
                    dayOfWeekColor = ConsoleColor.Yellow;
                    break;
                case DayOfWeek.Friday:
                    dayOfWeekColor = ConsoleColor.Red;
                    break;
                case DayOfWeek.Saturday:
                    dayOfWeekColor = ConsoleColor.Green;
                    break;
            }
            return dayOfWeekColor;
        }
    }
}
