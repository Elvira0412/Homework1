// На вход принимает число N , на выходе показывает все четные числа от 1 до N
int N=new int();
Console.Write("Введите число N:");
N=Convert.ToInt32(Console.ReadLine());
for (int i=1; i<= N; i++);
{
    if (i%2==0) Console.WriteLine(i);
    else i++;
}
