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

string[] ArrayString = new string[4] {"Hello", "2", "World",";-)"};
string[] ArrayString2 = new string[ArrayString.Length];
void Reconciliation (string[] ArrayString, string[] ArrayString2)
{
    for (int i = 0; i < ArrayString.Length; i++)
    {
    if (ArrayString[i].Length <= 3)
        {
        ArrayString2[i] = ArrayString[i];
        }
    }
}
void PrintArrayString(string[] ArrayString2)
{
    for (int i = 0; i < ArrayString2.Length; i++)
        {
        Console.WriteLine($" {ArrayString2[i]} ");
        }
    Console.WriteLine();
}
Reconciliation (ArrayString, ArrayString2);
PrintArrayString(ArrayString2);