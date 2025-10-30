namespace EmployeeDataAgent.DataModels
{
    public class PromptRequestMessage
    {
        public PromptRequestMessage() { }
        public string Role { get; set; }
        public string AgentId { get; set; }
        public string RequestId { get; set; }
        public PayanarssApplication Application { get; set; }
        public string PromptMessage {  get; set; }
    }
}
