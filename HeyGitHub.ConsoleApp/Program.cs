using HeyGitHub.ConsoleApp;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Hey GitHub!");

var today = DateTime.Today;
var persianDayOfWeekName = new DateTimeHelpers().GetPersianDayOfWeekName(today);
Console.ForegroundColor = new DateTimeHelpers().GetDayOfWeekColor(today);
Console.WriteLine(persianDayOfWeekName);
Console.ForegroundColor = ConsoleColor.White;

