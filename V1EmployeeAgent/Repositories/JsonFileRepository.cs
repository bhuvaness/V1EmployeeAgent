using EmployeeDataAgent.DataModels;
using EmployeeDataAgent.Services;
using System.Text.Json;

namespace EmployeeDataAgent.Repositories
{
    public class JsonFileRepository
    {
        // Save JSON string to file with table name
        public async Task<PromptResponseMessage> CreateJson(PromptRequestMessage request)
        {
            string fileName = $"Abc.json";

            // Beautify JSON (optional)
            using var doc = JsonDocument.Parse("");
            var options = new JsonSerializerOptions { WriteIndented = true };
            string formatted = JsonSerializer.Serialize(doc.RootElement, options);

            File.WriteAllText(fileName, formatted);

            PromptResponseMessage response = new PromptResponseMessage();

            return response;
        }
        public async Task<PromptResponseMessage> ReadJson(PromptRequestMessage request)
        {
            return null;
        }
        public async Task<PromptResponseMessage> UpdateJson(PromptRequestMessage request)
        {
            return null;
        }
        public async Task<PromptResponseMessage> DeleteJson(PromptRequestMessage request)
        {
            return null;
        }
    }
}
