using Sysdatec.PruebaTecnica.Api;
using Sysdatec.PruebaTecnica.Application;
using Sysdatec.PruebaTecnica.Common;
using Sysdatec.PruebaTecnica.External;
using Sysdatec.PruebaTecnica.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddWebApi()
    .AddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();

app.Run();

