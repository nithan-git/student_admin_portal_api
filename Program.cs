using StudentAdminPortal.API.DataModels;
using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.Repositories;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// add db services
builder.Services.AddDbContext<StudentAdminContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("StudentAdminPortalDb")));
// add repositories
builder.Services.AddScoped<IStudentRepository,SqlStudentRepository>();
builder.Services.AddScoped<IImageRepository,LocalStorageImageRepository>();
// add automappper
builder.Services.AddAutoMapper(typeof(Program));
// add validators
builder.Services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Program>());
// builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
