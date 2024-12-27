using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using UserManagementAPI.Services;
using UserManagementAPI.Middleware;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(5000); // استخدام المنفذ 5000 على localhost فقط
});
// ✅ إضافة خدمات Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ إضافة خدمات الـ Controllers
builder.Services.AddControllers();

var app = builder.Build();

// ✅ إضافة Swagger Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "User Management API v1");
        options.RoutePrefix = string.Empty; // يعرض Swagger في الصفحة الرئيسية
    });
}

// ✅ إضافة Middlewares
app.UseMiddleware<ErrorHandlingMiddleware>();
//app.UseMiddleware<UserManagementAPI.Middleware.AuthenticationMiddleware>();
app.UseMiddleware<LoggingMiddleware>();

// ✅ إضافة Authorization
app.UseAuthorization();

// ✅ ربط الـ Controllers
app.MapControllers();

// ✅ تشغيل التطبيق
app.Run();
