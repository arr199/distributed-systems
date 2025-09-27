WebApplication app = DefaultDistribSystemsWebApplication.Create();

app.MapGet("/", () => "Hello World!");
DefaultDistribSystemsWebApplication.Run(app);
