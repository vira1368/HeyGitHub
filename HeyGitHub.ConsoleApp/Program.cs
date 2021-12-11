using HeyGitHub.ConsoleApp;

Console.WriteLine("Hey GitHub!");

var today = DateTime.Today;
var persianDayOfWeekName = new DateTimeHelpers().GetPersianDayOfWeekName(today);
Console.WriteLine(persianDayOfWeekName);
