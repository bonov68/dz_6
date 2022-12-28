// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 
// 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числa через запятую: ");
string input = Console.ReadLine();
string [] arr = input.Split(','); 
int count = 0;

for (int i= 0; i < arr.Length; i++)
{
if(Convert.ToInt32(arr[i]) > 0)
{
    count++;
}
}
Console.Write(count);