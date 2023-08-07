using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

public class UserControllerTests : IClassFixture<TestFixture>
{
    private readonly TestFixture _fixture;
    private readonly HttpClient _client;

    public UserControllerTests(TestFixture fixture)
    {
        _fixture = fixture;
        _client = _fixture.CreateClient();
    }

    // Example test for the UserController's Get action
    [Fact]
    public async Task GetUser_ReturnsOkResult()
    {
        // Arrange (optional): Seed the in-memory database with test data

        // Act
        var response = await _client.GetAsync("/api/user");

        // Assert
        response.EnsureSuccessStatusCode(); // Status Code 200-299
        Assert.Equal("application/json; charset=utf-8",
            response.Content.Headers.ContentType.ToString());

        // Optionally, you can deserialize the response content and make further assertions
        // var responseContent = await response.Content.ReadAsStringAsync();
        // var users = JsonSerializer.Deserialize<List<User>>(responseContent);
        // Assert.NotNull(users);
        // Assert.Equal(expectedUserCount, users.Count);
    }
}