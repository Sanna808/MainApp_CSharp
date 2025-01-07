using Buisness.Interfaces;
using Buisness.Services;
using MainApp_CSharp.Services;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<IFileService, FileService>();
serviceCollection.AddSingleton<ContactService>();
serviceCollection.AddSingleton<IMenuService, MenuService>();

var serviceProvider = serviceCollection.BuildServiceProvider();
var menuService = serviceProvider.GetRequiredService<IMenuService>();

menuService.ShowMenu();