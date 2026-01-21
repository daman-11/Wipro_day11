public class ReportService
{
    private readonly IReportGenerator _generator;
    private readonly IReportSaver _saver;

    public ReportService(IReportGenerator generator, IReportSaver saver)
    {
        _generator = generator;
        _saver = saver;
    }

    public void Process()
    {
        var content = _generator.Generate();
        _saver.Save(content);
    }
}
