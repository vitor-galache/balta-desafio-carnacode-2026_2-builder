using BuilderChallenge.Entities;
using BuilderChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderChallenge.Builders;

internal class ReportBuilder : IReportBuilder
{
    private SalesReport _report = new SalesReport();

    public ReportBuilder()
    {
        Reset();
    }

    public SalesReport Build()
    {
        var salesReport = _report;

        Reset();

        return salesReport;
    }

    public void Reset()
    {
        _report = new SalesReport();
    }

    public IReportBuilder WithCharts(string chartType)
    {
        _report.IncludeCharts = true;
        _report.ChartType = chartType;
        return this;
    }

    public IReportBuilder WithColumns(params string[] columns)
    {
        _report.Columns.AddRange(columns);
        return this;
    }

    public IReportBuilder WithFilters(params string[] filters)
    {
        _report.Filters.AddRange(filters);
        return this;
    }

    public IReportBuilder WithFooter(string text)
    {
        _report.IncludeFooter = true;
        _report.FooterText = text;
        return this;
    }

    public IReportBuilder WithFormat(string format)
    {
        _report.Format = format;
        return this;
    }

    public IReportBuilder WithGrouping(string groupBy)
    {
        _report.GroupBy = groupBy;
        return this;
    }

    public IReportBuilder WithHeader(string text)
    {
        _report.IncludeHeader = true;
        _report.HeaderText = text;
        return this;
    }

    public IReportBuilder WithLogo(string logoPath)
    {
        _report.CompanyLogo = logoPath;
        return this;
    }

    public IReportBuilder WithPageSettings(string orientation, string pageSize, bool includePageNumbers = true)
    {
        _report.Orientation = orientation;
        _report.PageSize = pageSize;
        _report.IncludePageNumbers = includePageNumbers;
        return this;
    }

    public IReportBuilder WithPeriod(DateTime startDate, DateTime endDate)
    {
        _report.StartDate = startDate;
        _report.EndDate = endDate;
        return this;
    }

    public IReportBuilder WithSorting(string sortBy)
    {
        _report.SortBy = sortBy;
        return this;
    }

    public IReportBuilder WithSummary()
    {
        _report.IncludeSummary = true;
        return this;
    }

    public IReportBuilder WithTitle(string title)
    {
        _report.Title = title;
        return this;
    }

    public IReportBuilder WithTotals()
    {
        _report.IncludeTotals = true;
        return this;
    }

    public IReportBuilder WithWaterMark(string text)
    {
        _report.WaterMark = text;
        return this;
    }
}
