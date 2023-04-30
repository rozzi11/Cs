// 1.

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Write("Введите пятизначное число: ");
//         int number = int.Parse(Console.ReadLine());

//         int firstDigit = number / 10000; // первая цифра
//         int secondDigit = number / 1000 % 10; // вторая цифра
//         int fourthDigit = number / 10 % 10; // четвертая цифра
//         int fifthDigit = number % 10; // пятая цифра

//         if (firstDigit == fifthDigit && secondDigit == fourthDigit)
//         {
//             Console.WriteLine("Это палиндром");
//         }
//         else
//         {
//             Console.WriteLine("Это не палиндром");
//         }

//         Console.ReadLine();
//     }
// }

// 3.

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Введите координаты первой точки:");
//         Console.Write("X1 = ");
//         double x1 = double.Parse(Console.ReadLine());
//         Console.Write("Y1 = ");
//         double y1 = double.Parse(Console.ReadLine());
//         Console.Write("Z1 = ");
//         double z1 = double.Parse(Console.ReadLine());

//         Console.WriteLine("Введите координаты второй точки:");
//         Console.Write("X2 = ");
//         double x2 = double.Parse(Console.ReadLine());
//         Console.Write("Y2 = ");
//         double y2 = double.Parse(Console.ReadLine());
//         Console.Write("Z2 = ");
//         double z2 = double.Parse(Console.ReadLine());

//         double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
//         Console.WriteLine($"Расстояние между точками: {distance}");
//     }
// }

// 3.

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Write("Введите число N: ");
//         int n = int.Parse(Console.ReadLine());

//         Console.WriteLine("Таблица кубов чисел от 1 до N:");
//         for (int i = 1; i <= n; i++)
//         {
//             int cube = i * i * i;
//             Console.WriteLine($"{i}^3 = {cube}");
//         }
//     }
// }