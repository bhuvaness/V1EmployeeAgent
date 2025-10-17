namespace EmployeeDataAgent.DataModels
{
    public class PromptResponseMessage
    {
        public PromptResponseMessage() { }
        public string Id { get; set; }
        public string Message { get; set; }
        public RequestAction RequestAction { get; set; }
        public string DtoId { get; set; }
        public string DtoName { get; set; }
        public string Dto { get; set; }
    }
}
