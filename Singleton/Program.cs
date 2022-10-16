using Singleton;

Console.Title = "Singleton";

var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if(instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("Instances are the same");
}

Logger.Log($"Message from {nameof(instance1)}");
Logger.Log($"Message from {nameof(instance2)}");
Logger.Log($"Message from {nameof(Logger.Instance)}");
