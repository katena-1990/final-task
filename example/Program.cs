string[] M;
Console.WriteLine("Введите массив строк через пробел: ");
string stroka = Console.ReadLine();
M = stroka.Split(' ');
var result = new string[M.Length];
var size = 0;
foreach (var value in M)
{
if (value.Length<=3)
{
    result[size] = value;
    size++;
}
}
