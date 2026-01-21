using System;

public class FileReportSaver : IReportSaver
{
    public void Save(string content)
    {
        Console.WriteLine("Saved: " + content);
    }
}
