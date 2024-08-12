using DefinitionOfTriangle;
using DefinitionOfTriangle.App;
using DefinitionOfTriangle.App.Models;
using Microsoft.Extensions.DependencyInjection;

var services = ServiceCollectionExtensions.CreateServices();
var serviceProvider = services.BuildServiceProvider();
var myService = serviceProvider.GetRequiredService<IDefinitionOfTriangleService>();

var request = new DefinitionOfTriangleRequest();
Console.Write("Сторона треугольника a: ");
request.SideA = Convert.ToDouble(Console.ReadLine());

Console.Write("Сторона треугольника b: ");
request.SideB = Convert.ToDouble(Console.ReadLine());

Console.Write("Сторона треугольника c: ");
request.SideC = Convert.ToDouble(Console.ReadLine());

var result = myService.DetermineTriangleType(request);

Console.WriteLine(result.Description);
