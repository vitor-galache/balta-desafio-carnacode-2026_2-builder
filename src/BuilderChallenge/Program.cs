using BuilderChallenge;
using BuilderChallenge.Builders;
using BuilderChallenge.Builders.Directors;
using BuilderChallenge.Entities;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Relatórios ===");
        var reportBuilder = new ReportBuilder();

        var reportDirector = new ReportDirector(reportBuilder);

        var report1 = reportDirector.BuildMonthlyStandardReport("Vendas Mensais", new DateTime(2024, 1, 1));
        report1.Generate();

        // Problema 2: Muitos setters - ordem não importa, pode esquecer configurações obrigatórias
        var report2 = reportDirector.BuildQuarterlyPerformanceReport("Relatório Trimestral", 2024, 1);
       
        report2.Generate();

        // Problema 3: Relatórios com configurações parecidas exigem repetir muito código

        var report3 = reportDirector.BuildAnnualExecutiveReport("Venda Anuais", 2024);
       

        report3.Generate();

        // Perguntas para reflexão:
        // - Como criar relatórios complexos sem construtores gigantes?
        // - Como garantir que configurações obrigatórias sejam definidas?
        // - Como reutilizar configurações comuns entre relatórios?
        // - Como tornar o processo de criação mais legível e fluente?
    }
}
