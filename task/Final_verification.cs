// Ввод строк пользователем с проверкой
string[] InputKeywords()
{
  Console.Write("Какое количество строк изволите ввести? -> ");
  int NumberOfRows;
  string Temp = Console.ReadLine();
  while (!int.TryParse(Temp, out NumberOfRows) || NumberOfRows <= 0)
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

// Подсчет строк с количеством символов больше равно 3
int More3Symbol(string[] Arr)
{
  int count = 0;
  for (int i = 0; i < Arr.Length; i++)
  {
    if (Arr[i].Length <= 3)
    {
      count++;
    }
  }
  return count;
}

//Формирование нового массива из строк с количеством символом меньше равно 3
string[] ProcessAnArray(string[] Arr, int count)
{
  string[] ResultArray = new string[count];
  int j = 0;
  for (int i = 0; i < Arr.Length; i++)
  {
    if (Arr[i].Length <= 3)
    {
      ResultArray[j] = Arr[i];
      j++;
    }
  }
  return ResultArray;
}

Console.Clear();
string[] UserKeywords = InputKeywords();
string[] ProcessedArray = ProcessAnArray(UserKeywords, More3Symbol(UserKeywords));
// Вывод получившегося массива на экран для проверки
for (int i = 0; i < ProcessedArray.Length; i++)
{
  Console.WriteLine(ProcessedArray[i]);
}