namespace Tests;

using System.Text.RegularExpressions;
using knightmoves;
using Xunit;

public class AutogradingTest
{

    [Fact]
    public void Should_Make_LookUpBranding_Virtual(){
      string filePath = Path.GetDirectoryName(typeof(Organization).Assembly.Location) + "/../../../Organization.cs";

      Assert.True(File.Exists(filePath), "File does not exist");

      string content = File.ReadAllText(filePath);
      Regex rx = new Regex(@"sealed.*class.*Organization");

      bool hasComment = rx.IsMatch(content);

      Assert.True(hasComment, "Should make `LookUpBranding` virtual");

    }
}