﻿// Задача 1 по вводу и выводу

// Console.Write("Input your name ");
// string name = Console.ReadLine ();
// Console.Write("Hello!, ");
// Console.WriteLine(name);

// Задача 2. Сложение двух чисел

// int numberA = 1;
// int NumberB = 5;
// int result = numberA + NumberB;
// Console.WriteLine(result);

// Задача 3. Деление двух чисел

// double numberA = new Random().Next(1,15); // 1 2 3 4 ... 14
// Console.WriteLine(numberA);
// double NumberB = new Random().Next(1,15); // 1 2 3 4 ... 14
// Console.WriteLine(NumberB);
// double result = numberA / NumberB;
// Console.WriteLine(result);

// Задча 4. Персонализированное приветсвие

Console.Write("Input your name ");
string name = Console.ReadLine(); // пользовательский ввод

if(name.ToLower() == "masha")
{
    Console.Write("Great. This is Masha");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(name);
}
