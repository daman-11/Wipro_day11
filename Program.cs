class Program
{
    static void Main()
    {
        // DIP
        var service = new ReportService(
            new SimpleReportGenerator(),
            new FileReportSaver());
        service.Process();

        // Singleton
        Logger.Instance.Log("App Started");

        // Factory
        var doc = DocumentFactory.Create("PDF");
        doc.Open();

        // Observer
        var station = new WeatherStation();
        var display = new WeatherDisplay();
        station.Register(display);
        station.SetTemperature(30);
    }
}
