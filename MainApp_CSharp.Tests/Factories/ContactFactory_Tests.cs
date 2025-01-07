using Buisness.Factories;
using Buisness.Models;

namespace MainApp_CSharp.Tests.Factories;

public class ContactFactory_Tests
{
    [Fact]
    public void Create_ShouldReturnContactRegistrationForm()
    {
        // act
        var result = ContactFactory.Create();

        // assert
        Assert.NotNull(result);
        Assert.IsType<ContactRegistrationForm>(result);
    }

    [Fact]
    public void Create_ShouldReturnContactEntity_WhenContactRegistrationFormIsSupplied()
    {
        // arrange
        ContactRegistrationForm contactRegistrationForm = new();

        // act
        ContactEntity result = ContactFactory.Create(contactRegistrationForm);

        // assert
        Assert.IsType<ContactEntity>(result);
    }
}
