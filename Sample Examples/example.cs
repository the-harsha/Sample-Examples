using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Globalization;

class MainClass
{
    static async Task Main()
    {
        HttpClient client = new HttpClient();
        //perform Get request to fetch data 
        string s = await client.GetStringAsync("https://coderbyte.com/api/challenges/json/age-counting");

        //parse the Json response
        var sJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(s);

        //Get the 'data' field value which is a string
        string data = sJson["data"];

        //Split the data string into key-value pairs
        string[] keypair = data.Split(new[] { ", " }, StringSplitOptions.None);

        //Create a list to store the valid key-value pairs
        List<String> kValid = new List<string>();

        //Iterate through the items and check age
        for (int i = 0; i < keypair.Length; i = i + 2)
        {
            string KeyPart = keypair[i], Page = keypair[i + 1];

            //Extract the age value
            int valueage = int.Parse(Page.Split('=')[1]);

            //if age is not 1, add the key to the list
            if (valueage != 1)
            {
                kValid.Add(KeyPart.Split('=')[1]);
            }
        }
        Console.WriteLine(kValid.Count);

    }
}
