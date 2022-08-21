// Принимает на вход 3 числа и выдает max из этих чисел.
int userNumber1=new int();
int userNumber2=new int();
int userNumber3=new int();
Console.Write("Введите три числа:");
userNumber1=Convert.ToInt32(Console.ReadLine());
userNumber2=Convert.ToInt32(Console.ReadLine());
userNumber3=Convert.ToInt32(Console.ReadLine());
if (userNumber1>userNumber2 & userNumber1>userNumber3) Console.WriteLine("Max="+ userNumber1);
else if (userNumber2>userNumber3) Console.WriteLine("Max="+ userNumber2);
else Console.WriteLine("Max="+ userNumber3);