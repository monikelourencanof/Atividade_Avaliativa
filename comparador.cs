double n1 = 0.0;
double n2 = 0.0;

Console.WriteLine("Comparador de Números");

Console.WriteLine("Informe seu primeiro número: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe seu segundo número: ");
n2 = Convert.ToDouble(Console.ReadLine());

if (n1 > n2)
    Console.WriteLine($"O número {n1} é maior que {n2}!");
else if (n1 < n2)
    Console.WriteLine($"O número {n2} é maior que {n1}!");
else
    Console.WriteLine($"OS números {n1} e {n2} são iguais!");