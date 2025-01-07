using Buisness.Models;

namespace Buisness.Interfaces;

public interface IFileService
{
    void SaveListToFile(List<Contact> list);

    List<Contact> GetListfromFile();
}