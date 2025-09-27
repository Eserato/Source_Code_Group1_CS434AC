using Microsoft.EntityFrameworkCore;
using BookStoreAPI.Data;  // namespace chứa BookStoreContext

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:5500", "http://127.0.0.1:5500") // origin của file HTML
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Add DB context
builder.Services.AddDbContext<BookStoreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// ✅ Kiểm tra kết nối database (đặt sau khi app build)
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<BookStoreContext>();
    try
    {
        context.Database.OpenConnection();
        Console.WriteLine("✅ Kết nối database thành công!");
        context.Database.CloseConnection();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"❌ Lỗi kết nối database: {ex.Message}");
    }
}

// Middleware

// 🔹 Bật Swagger UI cho mọi môi trường
app.UseSwagger();
app.UseSwaggerUI();

// 🔹 Bật CORS cho mọi môi trường
app.UseCors("AllowFrontend");

app.UseAuthorization();
app.MapControllers();
app.Run();
