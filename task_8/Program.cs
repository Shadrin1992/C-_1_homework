// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<n; i++)
{
    int div = i%2;
    if(div != 0)
    {
        i++;
    }
    Console.WriteLine(i);    
}