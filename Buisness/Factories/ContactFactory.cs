using Buisness.Models;

namespace Buisness.Factories;

public static class ContactFactory
{
    public static ContactRegistrationForm Create()
    {
        return new ContactRegistrationForm();
    }

    public static ContactEntity Create(ContactRegistrationForm form)
    {
        return new ContactEntity()
        {
            FirstName = form.FirstName,
            LastName = form.LastName,
            Email = form.Email,
            Phone = form.Phone,
            Address = form.Address,
            PostalCode = form.PostalCode,
            City = form.City,
        };
    }

    public static Contact Create(ContactEntity entity)
    {
        return new Contact()
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Email = entity.Email,
            Phone = entity.Phone,
            Address = entity.Address,
            PostalCode = entity.PostalCode,
            City = entity.City,
        };
    }
}
