using Encurtador.Model;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

class Program
{
   static void Main(string[] args)
   {
      IConfigurationRoot configuration = new ConfigurationBuilder()
         .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
         .AddJsonFile("./appSettings.json", optional: true, reloadOnChange: true)
         .Build();

      Console.Write("Enter the link: ");

      string ApiKey = configuration["ApiKey"];
      string FullLink = Console.ReadLine();

      if (String.IsNullOrEmpty(ApiKey))
      {
         Console.WriteLine("API Key not found in appSettings.json");
         Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());
         return;
      }

      using (HttpClient client = new HttpClient())
      {
         client.BaseAddress = new Uri("https://cutt.ly/api/api.php");

         client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

         HttpResponseMessage response = client.GetAsync($"?key={ApiKey}&short={FullLink}&userDomain=0").Result;

         if (response.IsSuccessStatusCode)
         {
            var data = response.Content.ReadAsStringAsync().Result;
            var deserializeData = JsonSerializer.Deserialize<ApiResponse>(data);

            if (deserializeData?.Url.Status != null)
            {
               Console.WriteLine($"Status code: {deserializeData.Url.Status}");
               Console.WriteLine($"Full Link URL: {deserializeData.Url.FullLink}");
               Console.WriteLine($"Date: {deserializeData.Url.Date}");
               Console.WriteLine($"Short Link URL: {deserializeData.Url.ShortLink}");
               Console.WriteLine($"Link Title: {deserializeData.Url.Title}");
            }
            else
            {
               Console.WriteLine("Error");
            }
         }
         else
         {
            Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
         }
         client.Dispose();
      }
   }
}