// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

//Массив задан на старте выполнения алгоритма

string[] ArrayString = new string[4] { "Hello", "2", "world", ":-)" };
string[] ArrayString2 = new string[ArrayString.Length];

for (int i = 0; i < ArrayString.Length; i++)
{
    if (ArrayString[i].Length <= 3) ArrayString2[i] = ArrayString[i];
    else ArrayString2[i] = "";

}
string[] NewArray = ArrayString2.Except(new string[] { "" }).ToArray();  // string[] NewArray = ArrayString2.Where(s => s != "").ToArray();

for (int i = 0; i < NewArray.Length; i++)
{
    Console.Write($" [ {NewArray[i]} ] ");
}
Console.WriteLine();






