// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// ЕСЛИ ИСКОМАЯ ЦИФРА НАЧИНАЕТСЯ ПРИ ОТСЧЕТЕ СПРАВА!!!!!!!!!!


/*int inpt = new Random().Next();
int x = inpt / 100;
int result = x % 10;

Console.WriteLine("Введенное число: {0}", inpt);

if (x > 0)
{
    Console.WriteLine("Третья цифра в числе: {0}", result);
}
else
{
    Console.WriteLine("Третьей цифры в числе нет");
}*/


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// ЕСЛИ ИСКОМАЯ ЦИФРА НАЧИНАЕТСЯ ПРИ ОТСЧЕТЕ СЛЕВА!!!!!!!!!!



/*int inpt = new Random().Next();
int n = 1;
int res = 1;

if (inpt >= 100)
{
    while (n < inpt)
    {
        n = n * 10;
    }

    n = n / 100;
    res = inpt % n;

    n = n / 10;
    int result = res / n;
    Console.WriteLine("третья цифра заданного числа {0}", result);
}

else
    Console.WriteLine("третьей цифры нет");

Console.WriteLine(inpt);*/


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// ЕСЛИ ИСКОМАЯ ЦИФРА НАЧИНАЕТСЯ ПРИ ОТСЧЕТЕ СЛЕВА!!!!!!!!!! (с помощью конвертации и субстроки)

int inpt = new Random().Next();
string str = Convert.ToString(inpt);
int len = str.Length;

if (len > 2)
{
    string res = str.Substring(2, 1);
    int result = Convert.ToInt32(res);
    Console.WriteLine("третья цифра заданного числа {0}:", result);
}
else
    Console.WriteLine("третьей цифры нет");

Console.WriteLine(inpt);
