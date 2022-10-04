// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Ввод массива с клавиатуры и образование нового массива

Console.WriteLine("Введите значения:");
int count = 0;
string[] ArrayString = new string[count]; 
string[] ArrayString2 = new string[count]; // дополнительная переменная-ссылка - сохраняет старый массив строк
string s;
do
{
    s = Console.ReadLine();
    if (s != "") // Проверка, пустая ли строка
    {
        count++;
        ArrayString2 = new string[count];

        // скопировать старый массив в новый
        for (int i = 0; i < ArrayString2.Length - 1; i++)
            ArrayString2[i] = ArrayString[i];

        ArrayString2[count - 1] = s; // добавить последнюю введенную строку в массив ArrayString2
        ArrayString = ArrayString2;
    }
} while (s != "");

for (int i = 0; i < ArrayString.Length; i++)
{
    if (ArrayString[i].Length <= 3) ArrayString2[i] = ArrayString[i];
    else ArrayString2[i] = "";

}

 string[] NewArray = ArrayString2.Where(s => s != "").ToArray();

// печать массива конечного
void PrintArray(string[] array2)
{
    for (int i = 0; i < NewArray.Length; i++)
    {
        Console.Write($" [ {NewArray[i]} ] ");
    }
    Console.WriteLine();
}

PrintArray(NewArray);