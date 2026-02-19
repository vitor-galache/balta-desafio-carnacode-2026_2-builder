using BuilderChallenge.Entities;
using BuilderChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderChallenge.Builders.Directors;

internal class ReportDirector
{
    private readonly IReportBuilder _builder;

    public ReportDirector(IReportBuilder builder) => _builder = builder;

    public SalesReport BuildMonthlyStandardReport(string title, DateTime month)
    {
        var start = new DateTime(month.Year, month.Month, 1);
        var end = start.AddMonths(1).AddDays(-1);

        return _builder
            .WithTitle(title)
            .WithFormat("PDF")
            .WithPeriod(start, end)
            .WithHeader("Relatório de Vendas")
            .WithFooter("Confidencial")
            .WithColumns("Produto", "Quantidade", "Valor")
            .WithTotals()
            .WithPageSettings("Portrait", "A4")
            .Build();
    }

    public SalesReport BuildQuarterlyPerformanceReport(string title, int year, int quarter)
    {
        int startMonth = (quarter - 1) * 3 + 1;
        var start = new DateTime(year, startMonth, 1);
        var end = start.AddMonths(3).AddDays(-1);

        return _builder
            .WithTitle(title)
            .WithFormat("Excel")
            .WithPeriod(start, end)
            .WithColumns("Vendedor", "Região", "Total")
            .WithCharts("Line")
            .WithHeader("Cabeçalho - Relatorio")
            .WithGrouping("Região")
            .WithTotals()
            .Build();
    }

    public SalesReport BuildAnnualExecutiveReport(string title, int year)
    {
        return _builder
            .WithTitle(title)
            .WithFormat("PDF")
            .WithPeriod(new DateTime(year, 1, 1), new DateTime(year, 12, 31))
            .WithHeader("Relatório de Vendas")
            .WithFooter("Confidencial")
            .WithColumns("Produto", "Quantidade", "Valor")
            .WithCharts("Pie") // Gráfico de Pizza como solicitado
            .WithTotals()
            .WithPageSettings("Landscape", "A4") // Paisagem para caber mais dados
            .Build();
    }
}
