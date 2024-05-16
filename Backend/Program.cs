using Backend.Data;
using Backend.Service.Classs;
using Backend.Service.StudentInClasss;
using Backend.Service.Students;
using Backend.Service.TeacherInClasss;
using Backend.Service.Teachers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dang ki DB
var connectString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<Thuchanh6DbContext>(option => option.UseNpgsql(connectString));

builder.Services.AddTransient<IClassService, ClassService>();
builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddTransient<ITeacherService, TeacherService>();
builder.Services.AddTransient<ITeacherInClassService, TeacherInClassService>();
builder.Services.AddTransient<IStudentInClassService, StudentInClassService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Show UseCors
app.UseCors(builder =>
{
    builder.AllowAnyOrigin();
    builder.AllowAnyMethod();
    builder.AllowAnyHeader();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
