// Вывести расстояние между двумя
// точками в 3D по их координатам

Console.WriteLine("Введите x для точки 1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y для точки 1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z для точки 1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x для точки 2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x для точки 2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z для точки 2");
int z2 = Convert.ToInt32(Console.ReadLine());

double n = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2)+ Math.Pow(z1-z2, 2));

Console.WriteLine(n);

