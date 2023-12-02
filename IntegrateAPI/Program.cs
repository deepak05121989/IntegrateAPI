namespace IntegrateAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7202/WeatherForecast");
            
            request.Headers.Add("Authorization", "Basic dGVzdDp0ZXN0");
            var response = client.SendAsync(request).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();
            Console.WriteLine(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        }
    }
}