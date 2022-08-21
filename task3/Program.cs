// На вход принимает число и выдает,является ли число четным (делится ли оно на два без остатка)
int userNumber1=new int();
Console.Write("Введите число:");
userNumber1=Convert.ToInt32(Console.ReadLine());
if (userNumber1%2==0) Console.WriteLine($"Число {userNumber1} четное");
else Console.WriteLine($"Число { userNumber1} нечетное");

