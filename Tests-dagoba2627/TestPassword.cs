using TDD_dagoba2627;

namespace Tests_dagoba2627;

[TestClass]
public class TestPassword
{
    [TestMethod]
    public void TestPasswordCannotBeEmpty()
    {
        Assert.IsFalse(Password.CheckPassword(""));
    }

    [TestMethod]
    public void TestPasswordCannotBeNull()
    {
        Assert.IsFalse(Password.CheckPassword(null));
    }

    [TestMethod]
    [DataRow("1")]
    [DataRow("12")]
    [DataRow("123")]
    [DataRow("1234")]
    [DataRow("12345")]
    [DataRow("123456")]
    [DataRow("1234567")]
    public void TestPasswordIsAtLeastEightCharactersLong(string pass)
    {
        Assert.IsFalse(Password.CheckPassword(pass));
    }

    [TestMethod]
    public void TestPasswordContainsHashtag()
    {
        Assert.IsFalse(Password.CheckPassword("123456789"));
    }
}
