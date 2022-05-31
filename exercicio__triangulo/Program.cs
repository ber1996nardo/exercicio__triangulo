int l1 = 7;
int l2 = 7;
int l3 = 7;


if (l1 + l2 >= l3 && l1 + l3 >= l2 && l2 + l3 >= l1)
{
    if (l1 == l2 && l2 == l3 && l3 == l1)
    {
        Console.WriteLine("Triangulo Equilatero");
    }
    else if (l1 == l2 || l2 == l3 || l3 == l1)
    {
        Console.WriteLine("Triangulo Isosceles");
    }
    else if (l1 != l2 && l2 != l3 && l3 != l1)
    {
        Console.WriteLine("Triangulo Escaleno");
    }
}
else
    Console.WriteLine("Valores invalidos para formar um triangulo");

