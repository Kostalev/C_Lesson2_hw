// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*Console.WriteLine("Введите цифру дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        day = 1;
        Console.WriteLine("Понедельник рабочий день");
        break;

    case 2:
        day = 2;
        Console.WriteLine("Вторник рабочий день");
        break;

    case 3:
        day = 3;
        Console.WriteLine("Среда рабочий день");
        break;

    case 4:
        day = 4;
        Console.WriteLine("Четверг рабочий день");
        break;

    case 5:
        day = 5;
        Console.WriteLine("Пятница рабочий день");
        break;

    case 6:
        day = 6;
        Console.WriteLine("Суббота выходной день");
        break;

    case 7:
        day = 7;
        Console.WriteLine("Воскресенье выходной день");
        break;

    default:

        Console.WriteLine("В неделе всего семь дней");
        break;

}*/


Console.WriteLine("Введите цифру дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 & day <= 5)
{
    Console.WriteLine("С понедельника по пятницу рабочий день");
}
if (day >= 6 & day <= 7)
{
    Console.WriteLine("Суббота и воскресенье выходной день");
}
if (day < 1 | day > 7)
{
    Console.WriteLine("В неделе всего семь дней");
}


