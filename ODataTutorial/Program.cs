using Microsoft.AspNetCore.OData;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using ODataTutorial.Entities;


static IEdmModel GetEdmModel()
{
    ODataConventionModelBuilder builder = new();
    builder.EntitySet<Note>("Notes");
    return builder.GetEdmModel();
}

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddOData(opt => opt.AddRouteComponents("v1", GetEdmModel()).Filter().Select().Expand());
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "ODataTutorial", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();

app.MapControllers();

app.Run();
