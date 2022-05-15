using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Registro.Data;
using Registro.DAL;
using Microsoft.EntityFrameworkCore;
using Registro.Models;

/*Ocupaciones ocupacion = new Ocupaciones();

ocupacion.OcupacionId=0;
ocupacion.Descripcion="Profesional";
ocupacion.Salario = 30000;

var contexto = new Contexto();

contexto.Ocupaciones.Add(ocupacion);
contexto.SaveChanges();*/



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<Contexto>(options =>

    options.UseSqlite(builder.Configuration.GetConnectionString("Default"))    

);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
