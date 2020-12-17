# Host.ActivateService.Extension
Force service activation post HostBuilder build.

![Build](https://github.com/waxtell/Host.ActivateService.Extension/workflows/Build/badge.svg)
![Publish to nuget](https://github.com/waxtell/Host.ActivateService.Extension/workflows/Publish%20to%20nuget/badge.svg)

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