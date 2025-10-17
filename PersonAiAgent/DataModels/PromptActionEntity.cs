using System.Text.Json;

namespace PersonAiAgent.DataModels
{
    public class PromptActionEntity
    {
        public string Action { get; set; }
        public string Entity {  get; set; }
        public string Data {  get; set; }

        public void ParseData(string jsonData)
        {
            Dictionary<string, JsonElement> data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonData);
        }
    }
}
