double salarioHora;
int NumeroHora, NumeroHoraEx;

double Calcular(double salarioHora, int NumeroHora, int NumeroHoraEx)
{
    return NumeroHora * salarioHora + (NumeroHoraEx * salarioHora * 1.40);
}

Console.WriteLine("Digite o salário-hora base:");
salarioHora = double.Parse(Console.ReadLine()!);

Console.WriteLine("Digite o numero de horas trabalhadas:");
NumeroHora = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite o numero de horas extra trabalhadas:");
NumeroHoraEx = int.Parse(Console.ReadLine()!);

Console.Write($"Seu salário é: {Calcular(salarioHora, NumeroHora, NumeroHoraEx):C2}");

