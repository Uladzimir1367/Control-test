/*Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести из консоли/

При решении использовать массивы.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

//запрашиваем количество элементов в массиве;
int size = Prompt("Введите число элементов массива  ");
//формируем массив из элементов введённых пользователем;
string[] arrayString = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine()!);
    arrayString[i] = element;
}
// формируем массив в котором длина элемента не превышает 3 символа;
string[] arrayReceiv = new string[size];
int length = 3;
int index = 0;

for (int j = 0; j < size; j++)
{
    if (arrayString[j].Length <= length)
    {
        arrayReceiv[index] = arrayString[j];
        index++;
    }
}
// Вывод массивов исходного и полученного по условию;
 Console.WriteLine();
PrintArray(arrayString);
Console.WriteLine();
PrintArray(arrayReceiv);

// Методы ввода и вывода информации: из консоли, в консоль;


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Prompt(string message)
{
   Console.Write(message);
   int value = int.Parse(Console.ReadLine()!);
   return value;
}
