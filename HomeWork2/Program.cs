

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//  int num = new Random().Next(100,1000);
//  Console.WriteLine(num);

//  int num1= (num /10) % 10;
 
//  Console.WriteLine(num1);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// // int num = new Random().Next(10,40000);
// //   Console.WriteLine(num);
// Console.WriteLine("Введите число");
// int num=Convert.ToInt32(Console.ReadLine());
//   int result;

//   if (num > 99)
//   {
//     while(num>999)
//     {
//    num= num / 10;
//     }

//   result=num %10 ;
//   Console.WriteLine(result);
//   }

//   else
//   {
//      Console.WriteLine("Третьей цифры нет");
//   }

//   Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int num = new Random().Next(0,10);
Console.WriteLine(num);

if (num>5 && num<8)
{
    Console.WriteLine("Yes");
}

 else  if (num<6)
{
    Console.WriteLine("No");
}

  else if (num==0 || num>7)
{
    Console.WriteLine("Нет такого дня недели");
}
