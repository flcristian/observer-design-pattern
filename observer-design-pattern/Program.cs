using observer_design_pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        IObserver publisher = new Publisher();
        publisher.Subscribe(new Subscriber());
        publisher.Subscribe(new Subscriber());
        publisher.Subscribe(new Subscriber());
        publisher.Notify();
    }
}