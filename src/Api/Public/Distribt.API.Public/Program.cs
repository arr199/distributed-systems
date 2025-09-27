WebApplication app = DefaultDistribSystemsWebApplication.Create(builder =>
{
    builder
        .Services.AddReverseProxy()
        .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));
});

app.MapReverseProxy();

app.MapGet("/", () => "Hello World!");

DefaultDistribSystemsWebApplication.Run(app);
