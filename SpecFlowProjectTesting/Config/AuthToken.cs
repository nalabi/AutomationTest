using RestSharp;
using Newtonsoft.Json.Linq;

public class TokenClass
{
    private string accessToken;

    public TokenClass()
    {
        var client = new RestClient("https://hotrave.herokuapp.com/api/Account/login");
        var request = new RestRequest();
        request.AddHeader("Content-Type", "application/json");
        request.AddJsonBody(new { username = "Inno2", password = "1TestApp" });
        request.Method = Method.Post;

        var response = client.Execute(request);

        Console.WriteLine("Response Status Code: " + response.StatusCode);
        Console.WriteLine("Response Body: " + response.Content);

        // Extract the access token from the response body
        var jsonResponse = JObject.Parse(response.Content);
        this.accessToken = jsonResponse["token"]?.ToString();
    }
}
