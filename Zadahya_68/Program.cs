
int Acker (int m, int n)
{
    if (m == 0) 
    return n + 1;
    if (m != 0 && n == 0) 
    return Acker(m - 1, 1);
    if (m > 0 && n > 0) 
    return Acker(m - 1, Acker(m, n - 1));
    return Acker(m, n);
}

Console.Clear();
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {Acker(m, n)}");

// Денис, спасибо за семинары, было очень позновательно!!!!!!!

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
