namespace Singleton
{
    public class Logger
    {
        //thread safe, it handles locking 
        private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());

        /// <summary>
        /// old and not thread safe way
        /// </summary>
        //private static Logger? _instance;
        //public static Logger Instance => _instance ??= new Logger();

        public static Logger Instance => _lazyLogger.Value;

        protected Logger()
        {
        }
        public static void Log(string message) => Console.WriteLine($"Message to log {message}");
    }
}
