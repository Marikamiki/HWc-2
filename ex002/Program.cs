// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();


Console.Write("Enter a number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());

string anyNumberText = Convert.ToString(anyNumber);

if (anyNumberText.Length > 2){
  Console.WriteLine("the third digit:  " + anyNumberText[2]);
}
else {
  Console.WriteLine(" : there is no third digit");
}

