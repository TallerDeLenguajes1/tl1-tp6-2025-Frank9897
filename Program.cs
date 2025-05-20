// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
Console.WriteLine("Ingrese un numero entero");
string input  = Console.ReadLine();
int num = int.Parse(input);
Console.WriteLine($"valor de num:{num}");
int invertir=0;
while (num>0)
{
    invertir = invertir*10 + num%10;
    num = num/10;
}
Console.WriteLine($"valor de num:{invertir}");