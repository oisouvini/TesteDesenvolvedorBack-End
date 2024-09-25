using System;
using System.Linq; //Importei para facilitar em pegar o menor e o maior valor de faturamento

class FaturamentoDistribuidora
{
    static void Main()
    {
        double[] faturamento = { 1150.50, 2500.00, 4500.00, 0.0, 3200.00, 3700.00, 1700.00, 0.0 };

        var diasComFaturamento = faturamento.Where(valor => valor > 0).ToArray();

        double menorFaturamento = diasComFaturamento.Min();

        double maiorFaturamento = diasComFaturamento.Max();

        double mediaFaturamento = diasComFaturamento.Average();

        int diasAcimaMedia = diasComFaturamento.Count(valor => valor > mediaFaturamento);

        //O menor valor de faturamento ocorrido em um dia do ano;
        //O maior valor de faturamento ocorrido em um dia do ano;
        //Número de dias no ano em que o valor de faturamento diário foi superior à média anual.

        System.Console.WriteLine($"O menor valor de faturamento ocorrido em um dia do ano é: {menorFaturamento}");
        System.Console.WriteLine($"O maior valor de faturamento ocorrido em um dia do ano é: {maiorFaturamento}");
        System.Console.WriteLine($"O Número de dias no ano em que o valor de faturamento diário foi superior à média anual é: {diasAcimaMedia}");
    }
}