using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using OpenRouterClient;
using OpenRouterClient.Builders;
using OpenRouterClient.Services;
using OpenRouterClient.DTO;
using OpenRouterClient.DTO.Request;
using OpenRouterClient.Utilities;

namespace LinuxConversionExpert.Views;

public class PromptGenerator
{
    private readonly string _apiKey = Environment.GetEnvironmentVariable("OPENROUTER_API_KEY");
    private static readonly HttpClient _client = new HttpClient() {Timeout = TimeSpan.FromSeconds(30)};
    
    public string GeneratePrompt(ExperienceLevel level, OtherSystemExperience macExperience, OtherSystemExperience windowsExperience, List<Usage> usages, Age age)
    {
        string prompt = $"Find a few Linux distros that would be a good fit for someone who is a {level} user, ";
        switch (macExperience)
        {
            case OtherSystemExperience.None:
                prompt += "has not used macOS before, ";
                break;
            case OtherSystemExperience.DidNotUnderstand:
                prompt += "didn't like or understand how to use macOS, ";
                break;
            case OtherSystemExperience.Some:
                prompt += "has experience with macOS, ";
                break;
            case OtherSystemExperience.PowerUser:
                prompt += "is a macOS power user, ";
                break;
            default:
                throw new Exception("Question 2: at least one option has to be selected.");
        }
        
        switch (windowsExperience)
        {
            case OtherSystemExperience.None:
                prompt += "has not used Windows before, ";
                break;
            case OtherSystemExperience.DidNotUnderstand:
                prompt += "didn't like or understand how to use Windows, ";
                break;
            case OtherSystemExperience.Some:
                prompt += "has experience with Windows, ";
                break;
            case OtherSystemExperience.PowerUser:
                prompt += "is a Windows power user, ";
                break;
            default:
                throw new Exception("Question 2: at least one option has to be selected.");
        }

        // Get the usages in a string
        string usagesString = "";
        foreach (var usage in usages)
        {
            usagesString += $"{usage}, ";
        }

        prompt += $"wants to use Linux for {usagesString}";

        switch (age)
        {
            case Age.New:
                prompt += "and has a new computer.";
                break;
            case Age.Few:
                prompt += "and has a computer that is a few years old.";
                break;
            case Age.Over5:
                prompt += "and has a computer that is more than 5 years old.";
                break;
            case Age.Over10:
                prompt += "and has a computer that is more than 10 years old.";
                break;
            default:
                throw new Exception("Question 4: at least one option has to be selected.");
        }
        
        Console.WriteLine(prompt);
        return prompt;
    }

    public async Task<string> GetAiResults(string prompt)
    {
        OrClient client = new OrClient(apiUrl: "https://openrouter.ai/api/v1/chat/completions", apiToken: _apiKey);
        var response = client.Chat.
            WithModel("meta-llama/llama-3.2-3b-instruct:free").
            AddUserMessage(prompt)
            .SendAsync();

        var answer = response.Result?.Choices[0].Message;
        Console.WriteLine(response.Result?.Choices[0].Message);
        return answer.ToString();
    }
}