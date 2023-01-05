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
for (int i = 0; i < 3; i++)
{
    //Codigo da Peça - Numero de Peças - Valor Unitário;
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

Console.WriteLine("Exercicio 6 - Estrutura Sequencial");

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

Console.WriteLine("Exercicio 1 - Estrutura Condicional");
for (int i = 0; i < 3; i++)
{
    int numero = int.Parse(Console.ReadLine());

    if (numero < 0)
    {
        Console.WriteLine("NEGATIVO");
    }
    else
    {
        Console.WriteLine("NAO NEGATIVO");
    }
}


Console.WriteLine("Exercicio 2 - Estrutura Condicional");
for (int i = 0; i < 3; i++)
{
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine("PAR");
    }
    else
    {
        Console.WriteLine("IMPAR");
    }
}

Console.WriteLine("Exercicio 3 - Estrutura Condicional");
for (int i = 0; i < 3; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    int A = int.Parse(valores[0]);
    int B = int.Parse(valores[1]);

    if (A % B == 0 || B % A == 0)
    {
        Console.WriteLine("Sao Multiplos");
    }
    else
    {
        Console.WriteLine("Nao sao Multiplos");
    }
}

Console.WriteLine("Exercicio 4 - Estrutura Condicional");
for (int i = 0; i < 3; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    int horaInicial = int.Parse(valores[0]);
    int horaFinal = int.Parse(valores[1]);

    int duracao;
    if (horaInicial < horaFinal)
    {
        duracao = horaFinal - horaInicial;
    }
    else
    {
        duracao = 24 - horaInicial + horaFinal;
    }

    Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
}

Console.WriteLine("Exercicio 5 - Estrutura Condicional");
for (int i = 0; i < 3; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    int codigo = int.Parse(valores[0]);
    int quantidade = int.Parse(valores[1]);

    double total;
    if (codigo == 1)
    {
        total = quantidade * 4.0;
    }
    else if (codigo == 2)
    {
        total = quantidade * 4.5;
    }
    else if (codigo == 3)
    {
        total = quantidade * 5.0;
    }
    else if (codigo == 4)
    {
        total = quantidade * 2.0;
    }
    else
    {
        total = quantidade * 1.5;
    }

    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
}


Console.WriteLine("Exercicio 6 - Estrutura Condicional");
for (int i = 0; i < 3; i++)
{

    double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (numero < 0.0 || numero > 100.0)
    {
        Console.WriteLine("Fora de intervalo");
    }
    else if (numero <= 25.0)
    {
        Console.WriteLine("Intervalo [0,25]");
    }
    else if (numero <= 50.0)
    {
        Console.WriteLine("Intervalo (25,50]");
    }
    else if (numero <= 75.0)
    {
        Console.WriteLine("Intervalo (50,75]");
    }
    else
    {
        Console.WriteLine("Intervalo (75,100]");
    }
}

Console.WriteLine("Exercicio 7 - Estrutura Condicional");
for (int i = 0; i < 3; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
    double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

    if (x == 0.0 && y == 0.0)
    {
        Console.WriteLine("Origem");
    }
    else if (x == 0.0)
    {
        Console.WriteLine("Eixo Y");
    }
    else if (y == 0.0)
    {
        Console.WriteLine("Eixo X");
    }
    else if (x > 0.0 && y > 0.0)
    {
        Console.WriteLine("Q1");
    }
    else if (x < 0.0 && y > 0.0)
    {
        Console.WriteLine("Q2");
    }
    else if (x < 0.0 && y < 0.0)
    {
        Console.WriteLine("Q3");
    }
    else
    {
        Console.WriteLine("Q4");
    }
}

Console.WriteLine("Exercicio 8 - Estrutura Condicional");
for (int i = 0; i < 3; i++)
{
    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double imposto;
    if (salario <= 2000.0)
    {
        imposto = 0.0;
    }
    else if (salario <= 3000.0)
    {
        imposto = (salario - 2000.0) * 0.08;
    }
    else if (salario <= 4500.0)
    {
        imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
    }
    else
    {
        imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
    }

    if (imposto == 0.0)
    {
        Console.WriteLine("Isento");
    }
    else
    {
        Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
    }
}