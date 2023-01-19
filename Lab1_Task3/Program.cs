using System;
using System.Text.RegularExpressions;


public static class StringExtensions
{
    public static int Count(this string input, string substr)
    {
        return Regex.Matches(input, substr).Count;
    }
}

public class Example
{
    public static void Main()
    {
        string input = "првавпоизвольаппааавный теввксст";

        
        Console.Write("Введите количество пары символов для расчета: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        double I1 = 0;
        for (int i = 1; i <= n1; i++)
        {
            Console.Write("Введите пару символов: ");// Ввод пары символов
            string a = Convert.ToString(Console.ReadLine());
            int k = input.Count(a);//Вычисление количества вхождений пары символов в строку 
            Console.WriteLine("Количество пар символов К=" + k);
        }
        
        
        Console.ReadKey();

    }
}

