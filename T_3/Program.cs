// Задача 
// определить метод, который будет принимать
// число, факториал, которого нужно вычислить
// т.е. метод, который принимает элемент и возвращает 
// факториал числа

// int Factorial(int n) // возьмем метод, возвращающий int и в качестве аргумента возвращает другое число

// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(5));
// метод работает хорошо для малых чисел

// int Factorial(int n) // возьмем метод, возвращающий int и в качестве аргумента возвращает другое число

// {
//    // 1! = 1
//    // 0! = 1
//    if (n == 1) return 1;
//    else return n * Factorial(n - 1);
//  }
//  for (int i = 1; i < 40; i++) // для больших чисел - перегрузка
//   Console.WriteLine(Factorial(i));



// int Factorial(int n) // возьмем метод, возвращающий int и в качестве аргумента возвращает другое число

// {
//    if (n == 1) return 1;
//    else return n * Factorial(n - 1);
//  }
//  for (int i = 1; i < 40; i++) 
//   Console.WriteLine($"{i}! = {Factorial(i)}");
// // т.е. положительные числа идут до 17 знака


// double Factorial(int n) // решаем переполнение и получаем факториал 40!
// {
//    if (n == 1) return 1;
//    else return n * Factorial(n - 1);
//  }
//  for (int i = 1; i < 40; i++) 
//   Console.WriteLine($"{i}! = {Factorial(i)}");

// рекурсия Фибоначчи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
//  for (int i = 1; i < 10; i++)
//  {
//      Console.WriteLine(Fibonacci(i));

// }

// для 50 чисел ( с 36 идет медленнее)
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
 for (int i = 1; i < 50; i++)
 {
     Console.WriteLine($"f({i}) = {Fibonacci(i)}");

}