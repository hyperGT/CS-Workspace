// See https://aka.ms/new-console-template for more information

using firstProject.Models;

DateTime dateTime = DateTime.Now;

Console.WriteLine(dateTime.ToString("dd/MM/yyyy HH:mm"));

Person p1 = new();

p1.Name = "Gabriel";
p1.Age = 19;
p1.Present();