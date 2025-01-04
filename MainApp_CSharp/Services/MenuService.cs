using Buisness.Factories;
using Buisness.Models;
using Buisness.Services;

namespace MainApp_CSharp.Services;

public class MenuService : IMenuService
{
    private readonly ContactService _contactService = new ContactService();

    public void ShowMenu()
    {
        while (true)
        {
            MainMenu();
        }
    }

    public void MainMenu()
    {
        Console.Clear();
        Console.WriteLine("------- Contact List -------");
        Console.WriteLine($"{"1.",-5} Add new contact");
        Console.WriteLine($"{"2.",-5} View all contacts");
        Console.WriteLine($"{"3.",-5} Quit");
        Console.WriteLine("----------------------------");
        Console.Write("Please enter your menu option: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                AddOption();
                break;

            case "2":
                ViewOption();
                break;

            case "3":
                QuitOption();
                break;

            default:
                InvalidOption();
                break;
        }

    }


    public void AddOption()
    {
        ContactRegistrationForm contactRegistrationForm = ContactFactory.Create();
       
        Console.Clear();

        Console.Write("Enter first name: ");
        contactRegistrationForm.FirstName = Console.ReadLine()!;

        Console.Write("Enter last name: ");
        contactRegistrationForm.LastName = Console.ReadLine()!;

        Console.Write("Enter email adress: ");
        contactRegistrationForm.Email = Console.ReadLine()!;

        Console.Write("Enter phone number: ");
        contactRegistrationForm.Phone = Console.ReadLine()!;

        Console.Write("Enter adress: ");
        contactRegistrationForm.Address = Console.ReadLine()!;

        Console.Write("Enter postal code: ");
        contactRegistrationForm.PostalCode = Console.ReadLine()!;

        Console.Write("Enter city: ");
        contactRegistrationForm.City = Console.ReadLine()!;

        bool result = _contactService.Create(contactRegistrationForm);

        if (result)
            OutputDialog("Contact was successfully crated.");
        else
            OutputDialog("Contact was not crated successfully.");

    }

    public void ViewOption()
    {
        var contacts = _contactService.GetAll();

        Console.Clear();

        foreach (var contact in contacts)
        {
            Console.WriteLine($"{"Id: ", -5} {contact.Id}");
            Console.WriteLine($"{"Name: ",-5} {contact.FirstName} {contact.LastName}");
            Console.WriteLine($"{"Email: ",-5} {contact.Email}");
            Console.WriteLine($"{"Phone number: ",-5} {contact.Phone}");
            Console.WriteLine($"{"Adress: ",-5} {contact.Address}");
            Console.WriteLine($"{"Postal code: ",-5} {contact.PostalCode}");
            Console.WriteLine($"{"City: ",-5} {contact.City}");
            Console.WriteLine("");
        }

        Console.ReadKey();
    }

    public void QuitOption()
    {
        Console.Clear();
        Console.Write("Do you want to quit this application (y/n): ");
        var option = Console.ReadLine()!;

        if (option.Equals("y", StringComparison.CurrentCultureIgnoreCase))
        {
            Environment.Exit(0);
        }
    }

    public void InvalidOption()
    {
        Console.Clear();
        Console.WriteLine("You must enter a valid option.");
        Console.ReadKey();
    }

    public void OutputDialog(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Console.ReadKey();
    }
}
