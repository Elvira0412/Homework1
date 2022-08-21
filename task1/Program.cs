int userNumber1=new int();
int userNumber2=new int();
Console.Write("Введите два числа:");
userNumber1=Convert.ToInt32(Console.ReadLine());
userNumber2=Convert.ToInt32(Console.ReadLine());
if (userNumber1>userNumber2) Console.WriteLine($"Max={userNumber1}; Min= {userNumber2}");
else Console.WriteLine($"Max={userNumber2}; Min= {userNumber1}"); 