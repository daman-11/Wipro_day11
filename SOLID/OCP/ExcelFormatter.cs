public class ExcelFormatter : IReportFormatter
{
    public string Format(string content)
    {
        return "[EXCEL] " + content;
    }
}
