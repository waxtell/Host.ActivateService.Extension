# Host.ActivateService.Extension
Force service activation post HostBuilder build.

```csharp
 public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args)
                .Build()
                .ActivateService<YourTGoesHere>()
                .StartAsync()
            ;
        }
```