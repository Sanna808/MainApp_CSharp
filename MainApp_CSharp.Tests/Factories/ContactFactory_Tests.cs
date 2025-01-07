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
        ContactRegistrationForm contactRegistrationForm = new()
        {
            FirstName = "TestFirst",
            LastName = "TestLast",
            Email = "test@domain.com",
            Phone = "0731234567",
            Address = "TestAddress",
            PostalCode = "12345",
            City = "TestCity"
        };

        // act
        ContactEntity result = ContactFactory.Create(contactRegistrationForm);

        // assert
        Assert.NotNull(result);
        Assert.IsType<ContactEntity>(result);
        Assert.Equal(contactRegistrationForm.FirstName, result.FirstName);
        Assert.Equal(contactRegistrationForm.LastName, result.LastName);
        Assert.Equal(contactRegistrationForm.Email, result.Email);
        Assert.Equal(contactRegistrationForm.Phone, result.Phone);
        Assert.Equal(contactRegistrationForm.Address, result.Address);
        Assert.Equal(contactRegistrationForm.PostalCode, result.PostalCode);
        Assert.Equal(contactRegistrationForm.City, result.City);
    }

    [Fact]
    public void Create_ShouldReturnContact_WhenContactEntityIsSupplied()
    {
        // arrange
        ContactEntity contactEntity = new()
        {
            FirstName = "TestFirst",
            LastName = "TestLast",
            Email = "test@domain.com",
            Phone = "0731234567",
            Address = "TestAddress",
            PostalCode = "12345",
            City = "TestCity"
        };

        // act
        Contact result = ContactFactory.Create(contactEntity);

        // assert
        Assert.NotNull(result);
        Assert.IsType<Contact>(result);
        Assert.Equal(contactEntity.FirstName, result.FirstName);
        Assert.Equal(contactEntity.LastName, result.LastName);
        Assert.Equal(contactEntity.Email, result.Email);
        Assert.Equal(contactEntity.Phone, result.Phone);
        Assert.Equal(contactEntity.Address, result.Address);
        Assert.Equal(contactEntity.PostalCode, result.PostalCode);
        Assert.Equal(contactEntity.City, result.City);
    }
}
