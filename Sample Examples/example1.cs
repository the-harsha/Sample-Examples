using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class MainClass
{
    static async Task Main()
    {
        HttpClient client = new HttpClient();

        // Perform GET request to fetch the data
        string response = await client.GetStringAsync("https://coderbyte.com/api/challenges/json/age-counting");

        // Parse the JSON response
        var jsonResponse = JsonConvert.DeserializeObject<Dictionary<string, string>>(response);

        // Get the 'data' field value which is a string
        string dataString = jsonResponse["data"];

        // Split the data string into key-value pairs
        string[] items = dataString.Split(new[] { ", " }, StringSplitOptions.None);

        // Variable to count how many items have age >= 50
        int count = 0;

        // Iterate through the items and check the age
        for (int i = 0; i < items.Length; i += 2)
        {
            string agePart = items[i + 1];

            // Extract the age value
            int age = int.Parse(agePart.Split('=')[1]);

            // If the age is 50 or greater, increment the count
            if (age >= 50)
            {
                count++;
            }
        }

        // Output the final count
        Console.WriteLine(count);
    }
}
