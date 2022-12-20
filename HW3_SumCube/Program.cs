// Для числа N вывести 
// таблицу кубов от 1 до N
Console.WriteLine("Введите число N>0");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(1); 

for(int i = 2; i <= n; i++)
{
    Console.Write(", " + i * i* i); 
}
