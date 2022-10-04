Console.Write("Введите цифру ");
string a1 = Console.ReadLine();
int a = int.Parse(a1);

for (int i=1; i <=a; i+=1) {
    if(i%2 == 0) Console.WriteLine(i);
}; 
