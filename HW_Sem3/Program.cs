// вывести палиндром или нет сформированное 
// рандомно пятизначное число

// int number = new Random().Next(10000, 100000);

int number = new Random().Next(10000, 100000);
// int number = 12821;
Console.WriteLine(number);

int n5 = number / 10000;
int n4 = number % 10000 / 1000;
int n2 = number % 100 / 10;
int n1 = number % 10;

if(n5 == n1 && n4 == n2)
  Console.WriteLine("Да, число палиндром");
else
  Console.WriteLine("Нет, число не палиндром");