using System.Globalization;

Console.WriteLine("Exercicio 01 - Estrutura Sequencial");

for (int i = 0; i < 3; i++)
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    int soma = a + b;
    Console.WriteLine("SOMA = " + soma);
}

Console.WriteLine("Exercicio 02 - Estrutura Sequencial");

for (int i = 0; i < 3; i++)
{
    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double pii = 3.14159;

    double ca = raio * raio;
    double area = pii * ca;

    Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
}

Console.WriteLine("Exercicio 03 - Estrutura Sequencial");

for (int i = 0; i < 2; i++)
{
    int a3 = int.Parse(Console.ReadLine());
    int b3 = int.Parse(Console.ReadLine());
    int c3 = int.Parse(Console.ReadLine());
    int d3 = int.Parse(Console.ReadLine());

    int diferenca = (a3 * b3 - c3 * d3);

    Console.WriteLine("DIFERENÇA = " + diferenca);
}

Console.WriteLine("Exercicio 04 - Estrutura Sequencial");

for (int i = 0; i < 3; i++)
{
    int numero = int.Parse(Console.ReadLine());
    int horas = int.Parse(Console.ReadLine());
    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double pagamento = horas * salario;

    Console.WriteLine("NUMBER = " + numero);
    Console.WriteLine("SALARY = U$ " + pagamento.ToString("F2", CultureInfo.InvariantCulture));
}


Console.WriteLine("Exercicio 05 - Estrutura Sequencial");
//Codigo da Peça - Numero de Peças - Valor Unitário;
for (int i = 0; i < 3; i++)
{
    int cod1, cod2, qte1, qte2;
    double preco1, preco2, total;

    string[] valores = Console.ReadLine().Split(' ');

    cod1 = int.Parse(valores[0]);
    qte1 = int.Parse(valores[1]);
    preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

    valores = Console.ReadLine().Split(' ');
    cod2 = int.Parse(valores[0]);
    qte2 = int.Parse(valores[1]);
    preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

    total = preco1 * qte1 + preco2 * qte2;

    Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
}

Console.WriteLine("Exercicio 6- Estrutura Sequencial");

for (int i = 0; i < 2; i++)
{
    double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

    string[] vet = Console.ReadLine().Split(' ');
    A = double.Parse(vet[0], CultureInfo.InvariantCulture);
    B = double.Parse(vet[1], CultureInfo.InvariantCulture);
    C = double.Parse(vet[2], CultureInfo.InvariantCulture);

    triangulo = A * C / 2.0;
    circulo = 3.14159 * C * C;
    trapezio = (A + B) / 2.0 * C;
    quadrado = B * B;
    retangulo = A * B;


    Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

}

