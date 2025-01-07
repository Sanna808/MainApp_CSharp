using Buisness.Models;

namespace Buisness.Interfaces;

public interface IContactService
{
    bool Create(ContactRegistrationForm form);
}
