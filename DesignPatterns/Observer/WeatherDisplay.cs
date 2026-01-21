using System;

public class WeatherDisplay : IObserver
{
    public void Update(float temp)
    {
        Console.WriteLine("Temperature: " + temp);
    }
}
