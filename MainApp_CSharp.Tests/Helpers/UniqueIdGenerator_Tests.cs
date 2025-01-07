using Buisness.Helpers;

namespace MainApp_CSharp.Tests.Helpers;

public class UniqueIdGenerator_Tests
{
    [Fact]
    public void Generate_ShouldReturnStringOfTypeGuid()
    {
        // act
        string id = UniqueIdGenerator.GenerateUniqueId();

        // assert
        Assert.False(string.IsNullOrEmpty(id));
        Assert.True(Guid.TryParse(id, out _));
    }
}
