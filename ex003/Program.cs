//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Enter a number of day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("yep (WEEKENDS!)");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("not a weekday");
  }
  else Console.WriteLine("nope (it's not a weekend) ");
}

CheckingTheDayOfTheWeek(dayNumber);