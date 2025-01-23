//using Serilog;

using MunchyAPI.logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//In case to use the external logging library like serilog instead of default first install serilog packedes for asp.net in nuget packages
//then configure like this manually(configuration is coomented as the package is uninstall as its not neceassary)
//Serilog configuration i.e external logging library
//Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("logs/munchlogs.txt").CreateLogger();
//builder.Host.UseSerilog();

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ILogging, Logging>(); //singleton creates a single object when the app starts and used for every request for the implementation
//For AddScoped the object is created for every request of the implementaion class and used in the required part
//Similary for AddTransient object is  created for every access of the object another object is created and used for a single request
//for example for a single request of the implementation class if the service object is accessed for 10 times then more 10 objects are created and furtherly used in the required part 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
