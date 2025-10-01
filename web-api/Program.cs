var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();
var app = builder.Build();

app.UseStaticFiles();
app.MapGet("/", () => Results.Redirect("/index.html"));


// I was looking into various ways to inject these dependecies into the mapGet
// Currently, I am simple injecting into the parameters of the mapGet
// But I can also manually create them above it to keep track better seen below here...

// var config = app.Configuration;  // Gets the same IConfiguration
// var httpClient = app.Services.GetRequiredService<HttpClient>(); // Gets HttpClient from DI

// app.MapGet("/weather", async (double lat, double lon) =>
// {
//     var apiKey = config["OpenWeatherMap:ApiKey"];
//     var response = await httpClient.GetAsync(url);
// });

// API endpoint for the weather
app.MapGet("/weather", async (double lat, double lon, IConfiguration config, HttpClient httpClient) =>
{
    var apiKey = config["OpenWeatherMap:ApiKey"];
    var baseUrl = config["OpenWeatherMap:BaseUrl"];
    var url = $"{baseUrl}/weather?lat={lat}&lon={lon}&appid={apiKey}&units=metric";

    var response = await httpClient.GetAsync(url);
    var content = await response.Content.ReadAsStringAsync();
    return Results.Ok(content);
});

// tag decoration
// [route("/weather")]


app.Run();