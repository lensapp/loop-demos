using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
if (string.IsNullOrWhiteSpace(apiKey))
{
    Console.WriteLine("Missing OPENAI_API_KEY environment variable.");
    return;
}

const string url = "http://localhost:31300/openai/v1/chat/completions";

using var http = new HttpClient();
http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

Console.WriteLine("I am console bot. Ask me anything.");
Console.WriteLine("Type 'exit' to quit.");

while (true)
{
    Console.Write("> ");
    var prompt = Console.ReadLine();

    if (prompt is null)
        continue;

    if (prompt.Equals("exit", StringComparison.OrdinalIgnoreCase))
        break;

    if (string.IsNullOrWhiteSpace(prompt))
        continue;

    var payload = new
    {
        model = "gpt-4o",
        messages = new[] { new { role = "user", content = prompt } }
    };

    using var content = new StringContent(
        JsonSerializer.Serialize(payload),
        Encoding.UTF8,
        "application/json");

    using var resp = await http.PostAsync(url, content);
    var body = await resp.Content.ReadAsStringAsync();

    if (!resp.IsSuccessStatusCode)
    {
        Console.WriteLine($"HTTP {(int)resp.StatusCode}: {body}");
        Console.WriteLine("Type 'exit' to quit.");
        continue;
    }

    using var doc = JsonDocument.Parse(body);
    var reply = doc.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();

    Console.WriteLine();
    Console.WriteLine(reply);
    Console.WriteLine();
    Console.WriteLine("Type 'exit' to quit.");
}