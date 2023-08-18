using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.JSInterop;



public class AuthService
{
    private readonly HttpClient httpClient;
    private readonly IJSRuntime jsRuntime;

    public AuthService(HttpClient httpClient, IJSRuntime jsRuntime)
    {
        this.httpClient = httpClient;
        this.jsRuntime = jsRuntime;
    }

    public void SetAuthorizationHeader(string token)
    {
        // Add the JWT token to the HTTP client's default request headers
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
    }

    public async Task<string?> GetAccessTokenAsync()
    {
        // Retrieve the JWT token from local storage
        return await jsRuntime.InvokeAsync<string>("localStorage.getItem", "accessToken");
    }
}
public interface IAuthenticationService
{
    bool IsLoggedIn { get; }
    Task Login( string token);
    Task Logout();
}

public class AuthenticationService : IAuthenticationService
{
    public bool IsLoggedIn { get; private set; } = false;

    public async Task Login( string token)
    {
        // Here, you can perform any additional login logic, like storing the token in local storage or handling JWT token validation.

        // For simplicity, we are just setting IsLoggedIn to true when the user logs in.
        IsLoggedIn = true;
    }

    public async Task Logout()
    {
        // Here, you can perform any additional logout logic, like clearing local storage or JWT token.

        // For simplicity, we are just setting IsLoggedIn to false when the user logs out.
        IsLoggedIn = false;
    }
}
