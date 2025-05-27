using OpenAI.API.Example.Services;
using OpenAI.GPT3.Extensions;


IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddOpenAIService(settings =>
        {
            settings.ApiKey = context.Configuration["OpenAI:ApiKey"];
        });
        //services.AddHostedService<OpenAICompletionService>();
        services.AddHostedService<OpenAIImageService>();
    })
    .Build();

host.Run();