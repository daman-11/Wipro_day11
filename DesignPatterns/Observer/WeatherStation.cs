using System.Collections.Generic;

public class WeatherStation : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private float temperature;

    public void SetTemperature(float temp)
    {
        temperature = temp;
        Notify();
    }

    public void Register(IObserver observer) => observers.Add(observer);
    public void Remove(IObserver observer) => observers.Remove(observer);

    public void Notify()
    {
        foreach (var obs in observers)
            obs.Update(temperature);
    }
}
