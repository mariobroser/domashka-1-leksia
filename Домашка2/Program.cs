Console.Write("Введите первую цифру ");
string a1 = Console.ReadLine();
int a = int.Parse(a1);
Console.Write("Введите вторую цифру ");
string b1 = Console.ReadLine();
int b = int.Parse(b1);
Console.Write("Введите третью цифру ");
string c1 = Console.ReadLine();
int c = int.Parse(c1);
int max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;

Console.Write("max= ");
Console.Write(max);



