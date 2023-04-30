
// 1.
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Введите первое число:");
//         int number1 = int.Parse(Console.ReadLine());

//         Console.WriteLine("Введите второе число:");
//         int number2 = int.Parse(Console.ReadLine());

//         if (number1 > number2)
//         {
//             Console.WriteLine("Первое число больше второго");
//         }
//         else if (number2 > number1)
//         {
//             Console.WriteLine("Второе число больше первого");
//         }
//         else
//         {
//             Console.WriteLine("Числа равны");
//         }

//         Console.ReadLine();
//     }
// }

// 2.

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Введите три числа:");

//         int a = int.Parse(Console.ReadLine());
//         int b = int.Parse(Console.ReadLine());
//         int c = int.Parse(Console.ReadLine());

//         int max = a;

//         if (b > max)
//         {
//             max = b;
//         }

//         if (c > max)
//         {
//             max = c;
//         }

//         Console.WriteLine("Максимальное число: " + max);
//     }
// }

// 3.

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Введите число:");

//         int number = int.Parse(Console.ReadLine());

//         if (number % 2 == 0)
//         {
//             Console.WriteLine("Число " + number + " является четным");
//         }
//         else
//         {
//             Console.WriteLine("Число " + number + " не является четным");
//         }
//     }
// }

// 4.

// internal class NewBaseType
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Введите число:");

//         int n = int.Parse(Console.ReadLine());

//         Console.WriteLine("Четные числа от 1 до " + n + ":");

//         for (int i = 2; i <= n; i += 2)
//         {
//             Console.WriteLine(i);
//         }
//     }
// }


