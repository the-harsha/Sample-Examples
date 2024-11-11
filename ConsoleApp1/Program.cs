using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;


public class Program
{
    public static void Main()
    {
        string[] array = { "hello", "world", "World", "world", "1", "21", "1", "hello", "hello", "hellO" };

        var occurances = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        foreach (var item in array)
        {
            var key = item.Trim().ToLower();

            if (occurances.ContainsKey(key))
                occurances[key]++;
            else
            {
                occurances[key] = 1;
            }
        }
        string jsonOutput = JsonConvert.SerializeObject(occurances, Newtonsoft.Json.Formatting.Indented);

        Console.WriteLine(jsonOutput);


    }
}