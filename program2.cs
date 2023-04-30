// 1.
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Введите трехзначное число:");

//         int number = int.Parse(Console.ReadLine());

//         int secondDig = number / 10 % 10;

//         Console.WriteLine("Вторая цифра числа " + number + " равна " + secondDig);
//     }
// }

// 2.

// class program2
// {
//     static void Main()
//     {
//         Console.Write("Введите число: ");
//         string input = Console.ReadLine();

//         if (input.Length >= 3)
//         {
//             char thirdDigit = input[2];
//             Console.WriteLine("Третья цифра числа {0} равна {1}", input, thirdDigit);
//         }
//         else
//         {
//             Console.WriteLine("У числа нет третьей цифры");
//         }

//         Console.ReadLine();
//     }
// }

// 3.

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Write("Введите цифру дня недели: ");
//         int dayOfWeek = int.Parse(Console.ReadLine());

//         if (dayOfWeek == 6 || dayOfWeek == 7)
//         {
//             Console.WriteLine("Это выходной день");
//         }
//         else
//         {
//             Console.WriteLine("Это рабочий день");
//         }

//         Console.ReadLine();
//     }
// }