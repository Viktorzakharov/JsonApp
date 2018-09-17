using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace JsonApp
{
    class Program
    {
        static void Main()
        {
            var client = new WebClient();
            client.DownloadFile("https://jsonplaceholder.typicode.com/todos", "FileJson.json");

            var file = new StreamReader("FileJson.json");
            var jsonArray = JsonConvert.DeserializeObject<List<User>>(file.ReadToEnd());

            var dictionary = new Dictionary<string, int[]>();
            foreach (var e in jsonArray)
            {
                if (!dictionary.ContainsKey(e.UserId))
                    dictionary[e.UserId] = new int[2];
                dictionary[e.UserId][0]++;
                if (e.Completed) dictionary[e.UserId][1]++;
            }

            Console.WriteLine("{0,-20}{1,-20}{2}", "UserId", "TasksCount", "CompletedTasksAmount");
            foreach (var e in dictionary)
                Console.WriteLine("{0,-20}{1,-20}{2}", e.Key, e.Value[0], e.Value[1]);
        }
    }
}
