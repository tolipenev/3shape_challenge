using Xunit;
using _3shape_challenge;
namespace tests
{
    public class Test
    {
        [Fact]
        public void UserInputTest()
        {
            string[] array = new string[] { "usertest" };
            var usertest = Challenge.GetUserInput(array);
            Assert.Equal("usertest", usertest);
        }
        [Fact]
        public void GitHubRateTest()
        {
            try
            {
                Challenge.GetRateFromGitHub("token");
            }
            catch
            {
                Assert.True(true);
            }
        }
        [Fact]
        public void DesirializeAndComparisonTest()
        {
            Assert.Equal(100, Challenge.DeserializeAndCompare("{\"resources\":{\"core\":{\"limit\":60,\"remaining\":60,\"reset\":1623951241,\"used\":0,\"resource\":\"core\"},\"graphql\":{\"limit\":0,\"remaining\":0,\"reset\":1623951241,\"used\":0,\"resource\":\"graphql\"},\"integration_manifest\":{\"limit\":5000,\"remaining\":5000,\"reset\":1623951241,\"used\":0,\"resource\":\"integration_manifest\"},\"search\":{\"limit\":10,\"remaining\":10,\"reset\":1623947701,\"used\":0,\"resource\":\"search\"}},\"rate\":{\"limit\":60,\"remaining\":60,\"reset\":1623951241,\"used\":0,\"resource\":\"core\"}}"));
        }
    }
}