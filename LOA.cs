/*
Почувствуй себя интерном
 0. Вывести квадрат числа
 1. По двум заданным числам проверять является ли первое квадратом второго
 2. Даны два числа. Показать большее и меньшее число
 3. По заданному номеру дня недели вывести его название
 4. Найти максимальное из трех чисел
 5. Написать программу вычисления значения функции y=f(a)
 6. Выяснить является ли число чётным
 7. Показать числа от -N до N
 8. Показать четные числа от 1 до N
 9. Показать последнюю цифру трёхзначного числа
10. Показать вторую цифру трёхзначного числа
11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
12. Удалить вторую цифру трёхзначного числа
13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
14. Найти третью цифру числа или сообщить, что её нет
*/

// Семинар 05.11.2021 г. Ветка с решениями - Лютый Олег.

// 0. Вывести квадрат числа

void Zadanie0(int number)
{
    Console.WriteLine(number * number);
}

// 1. По двум заданным числам проверять является ли первое квадратом второго

bool Zadanie1(int num1, int num2)
{
    return (num1 == num2 * num2);
}

// 2. Даны два числа. Показать большее и меньшее число

void Zadanie2(int num1, int num2)
{
    if (num1 > num2) Console.WriteLine($"Большее: {num1}, меньшее: {num2}");
    else Console.WriteLine($"Большее: {num2}, меньшее: {num1}");
}

//3. По заданному номеру дня недели вывести его название

void Zadanie3(int day)
{
    string s = String.Empty;

    if (day == 1) s = "понедельник";
    if (day == 2) s = "вторник";
    if (day == 3) s = "среда";
    if (day == 4) s = "четверг";
    if (day == 5) s = "пятница";
    if (day == 6) s = "суббота";
    if (day == 7) s = "воскресенье";

    Console.WriteLine(s);
}

//4. Найти максимальное из трех чисел

int Zadanie4(int num1, int num2, int num3)
{
    int max = num1;
    if (num2 > max) max = num2;
    if (num3 > max) max = num3;

    return max;
}

// 5. Написать программу вычисления значения функции y=f(a)
// н/р y=sin(a) или y=cos(a)

double Zadanie5(double a)
{
    // y=sin(a)
    return Math.Sin(a);
}

// 6. Выяснить является ли число чётным

bool Zadanie6(int number)
{
    return number % 2 == 0;
}

// 7. Показать числа от -N до N

void Zadanie7(int number)
{
    for (int i = -number; i <= number; i++)
        Console.WriteLine(i);
}

// 8. Показать четные числа от 1 до N

void Zadanie8(int number)
{
    for (int i = 1; i <= number; i++)
        if (i % 2 == 0)
            Console.WriteLine(i);
}

// 9. Показать последнюю цифру трёхзначного числа

void Zadanie9(int number)
{
    Console.WriteLine(number % 10);
}

// 10. Показать вторую цифру трёхзначного числа

void Zadanie10(int number)
{
    Console.WriteLine((number / 10) % 10);
    Console.WriteLine(Convert.ToString(number)[1]);
}

//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

void Zadanie11(int number)
{
    int n1 = number / 10;
    int n2 = number % 10;

    int max = (n1 > n2) ? n1 : n2;
    Console.WriteLine(max);
}

// 12. Удалить вторую цифру трёхзначного числа
int Zadanie12(int number)
{
    int c1 = number / 100;
    int c3 = number % 10;

    return c1 * 10 + c3;
}


// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
void Zadanie13(int number)
{
    Console.WriteLine("Задайте число: ");
    int zadannoeChislo = int.Parse(Console.ReadLine());
    if (number % zadannoeChislo != 0)
        Console.WriteLine(number%zadannoeChislo);
}

//14. Найти третью цифру числа или сообщить, что её нет
void Zadanie14(int number)
{
    string s=Convert.ToString(Math.Abs(number));
    if (s.Length>2) Console.WriteLine($"В числе {number} третья цифра - {s[3]}");
    else Console.WriteLine($"Третьей цифры в числе {number} нет");
}

//Zadanie0();