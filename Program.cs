// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Введите пятизначное число : ");
// string enterNum = Console.ReadLine();
// int num = Convert.ToInt32(enterNum);
// int temp = num;
// int result = 0;

// if (num < 10000 || num > 99999)
// {
//     Console.WriteLine($"Введено не пятизначное число : {num}");
// }
// else
// {

// int num1 = temp % 10;
// temp = temp / 10;
// result = result + num1 * 10000;

// int num2 = temp % 10;
// temp = temp / 10;
// result = result + num2 * 1000;

// int num3 = temp % 10;
// temp = temp / 10;
// result = result + num3 * 100;

// int num4 = temp % 10;
// temp = temp / 10;
// result = result + num4 * 10;

// int num5 = temp % 10;
// temp = temp / 10;
// result = result + num5;

//     if (num == result)
//         {
//         Console.WriteLine($"Введено число : {num}, является палиндромом.");
//         }
//     else
//     {
//         Console.WriteLine($"Введено число : {num}, неявляется палиндромом.");
//     }
// }




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Double x1, y1, z1, x2, y2, z2, distance;

// Console.Write("Введите координаты первой точки по оси x: ");
// x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("По оси y: ");
// y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("По оси z: ");
// z1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты второй точки по оси x: ");
// x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("По оси y: ");
// y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("По оси z: ");
// z2 = Convert.ToDouble(Console.ReadLine());

// distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"Расстояние между двумя точками в пространстве равно {Math.Round(distance, 2)}");




// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число : ");
// string enterNum = Console.ReadLine();
// double num = Convert.ToDouble(enterNum);

// Console.WriteLine("Введите степень : ");
// string enterDegree = Console.ReadLine();
// double degree = Convert.ToDouble(enterDegree);

// double i = 1;

// while (i <= num)
// {
//     double result = Math.Pow(i, degree);
//     Console.Write($"{result}, ");
//     i++;
// }