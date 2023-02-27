//

string[] InputKeywords()
{
  Console.Write("Какое количество строк изволите ввести? -> ");
  int NumberOfRows;
  string Temp = Console.ReadLine();
  while (!int.TryParse(Temp, out NumberOfRows) && NumberOfRows <= 0)
  {
    Console.Write("Вы ввели не целое и положительное число! Попробуйте еще разок -> ");
    Temp = Console.ReadLine();
  }
  string[] Keywords = new string[NumberOfRows];
  for (int i = 0; i < NumberOfRows; i++)
  {
    Console.Write($"Введите строку {i + 1} -> ");
    Keywords[i] = Console.ReadLine();
  }
  return Keywords;
}

Console.Clear();
string[] UserKeywords = InputKeywords();

//Console.Write(UserKeywords);