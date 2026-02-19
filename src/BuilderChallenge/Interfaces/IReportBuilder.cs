using BuilderChallenge.Entities;
using System;
using System.Collections.Generic;

namespace BuilderChallenge.Interfaces;

public interface IReportBuilder
{
    void Reset();
    SalesReport Build();

    IReportBuilder WithTitle(string title);
    IReportBuilder WithFormat(string format);
    IReportBuilder WithPeriod(DateTime startDate, DateTime endDate);
    IReportBuilder WithHeader(string text);
    IReportBuilder WithFooter(string text);
    IReportBuilder WithCharts(string chartType);
    IReportBuilder WithSummary();
    IReportBuilder WithColumns(params string[] columns);
    IReportBuilder WithFilters(params string[] filters);
    IReportBuilder WithGrouping(string groupBy);
    IReportBuilder WithSorting(string sortBy);
    IReportBuilder WithTotals();
    IReportBuilder WithPageSettings(string orientation, string pageSize, bool includePageNumbers = true);
    IReportBuilder WithLogo(string logoPath);
    IReportBuilder WithWaterMark(string text);
}
