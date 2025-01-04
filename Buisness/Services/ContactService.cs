using Buisness.Factories;
using Buisness.Helpers;
using Buisness.Models;
using System.Diagnostics;

namespace Buisness.Services;

public class ContactService
{
    private List<Contact> _contacts = [];
    private readonly FileService _fileservice = new();

    public bool Create(ContactRegistrationForm form)
    {
        try
        {
            ContactEntity contactEntity = ContactFactory.Create(form);
            contactEntity.Id = UniqueIdGenerator.GenerateUniqueId();

            Contact contact = ContactFactory.Create(contactEntity);

            _contacts.Add(contact);
            _fileservice.SaveListToFile(_contacts);
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }

    public IEnumerable<Contact> GetAll()
    {
        _contacts = _fileservice.GetListfromFile();
        return _contacts;
    }
}
