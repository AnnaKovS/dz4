//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.Write("Введите a ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b ");
int b = Convert.ToInt32(Console.ReadLine());


int Degre(int num, int deg)
{
    int degre = 1;
    for (int i = 1; i <= deg; i++)
    {
        degre = degre * num;
    }
    return degre;
}

Console.WriteLine($"{a} в степени {b} равно {Degre (a,b)}");