namespace EmployeeDataAgent.DataModels
{
    public enum RequestAction
    {
        Create,
        Read,
        Update,
        Delete
    }
    public class PromptRequestMessage
    {
        public PromptRequestMessage() { }
        public string RequestId { get; set; }
        public string DtoName { get; set; }
        public string Dto { get; set; }
        public RequestAction Action { get; set; }
    }
}
