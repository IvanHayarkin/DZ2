
/*
Console.WriteLine("Введите трехзначное число.\nВыхода из программы команда Exit.");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }
    */

/*
int n = int.Parse(Console.ReadLine());

int k = (int)Math.Log10(n)-2;

Console.WriteLine(k < 0 ? "Не трехзначное число" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());

Console.ReadLine();
*/

/*
int dayNumber = ReadInt("Введите число от 1 до 7: ");

Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Под цифрой " + a + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    return " день.";
}
/*