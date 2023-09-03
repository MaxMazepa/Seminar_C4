// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// int InputNum(string message)
// {
// System.Console.WriteLine(message);
// return int.Parse(Console.ReadLine()!);
// }

// int SqureNum(int num)
// {
// while (count <= B)
// {
//     squre *= A;
//     Count++;
// }
// return squre;
// }

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!); 
int count = 0;
int res = 1;      // Пытался решать с помощью методов, но вообще не понимаю как разобраться в структуре, для меня слишком запутанно...Лекции и семинары смотрел

while (count < B)
{
    res = res*A;
    count++;
}
System.Console.WriteLine(res);

