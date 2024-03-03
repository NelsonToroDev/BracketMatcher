using BracketMatcher;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("(coder)(byte))", "0" )]
        [InlineData("(c(oder)) b(yte)", "1" )]
        public void Test1(string str, string expected)
        {
            var result = ProgramBracketMatcher.BracketMatcher(str);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("(coder)(byte))", "0")]
        [InlineData("(c(oder)) b(yte)", "1")]
        public void TestSolution(string str, string expected)
        {
            var result = Solution.BracketMatcher(str);
            Assert.Equal(expected, result);
        }
    }
}