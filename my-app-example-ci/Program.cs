var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Endpoint raiz
app.MapGet("/", () => $"Olá turma de sistemas, DevOps com .NET! {DateTime.UtcNow}");

// Endpoint de status
app.MapGet("/status", () => new 
{
    status = "OK",
    timestamp = DateTime.UtcNow
});

// Endpoint exemplo com parâmetro
app.MapGet("/saudacao/{nome}", (string nome) =>
{
    return $"Olá, {nome}! Bem-vindo à API .NET 🚀";
});

app.Run();