using Microsoft.Extensions.Logging;

namespace cSharpPresentation
{
    internal class loggingExample
    {
       
            internal static void Run()
            {
                var logger = CreateLogger();

                // Sample person object
                var person = new PersonClass
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 30
                };

                logger.LogInformation("Normal logging: {person}", person);
                logger.LogInformation("Log with destructuring: {@person}", person);
            }

        private static ILogger<loggingExample> CreateLogger()
        {
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddJsonConsole(); // Use JSON console logging
                builder.SetMinimumLevel(LogLevel.Debug);
            });

            return loggerFactory.CreateLogger<loggingExample>();
        }

    }
}
