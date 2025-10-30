using EmployeeDataAgent.DataModels;
using EmployeeDataAgent.Repositories;
using System.Text.Json;

namespace EmployeeDataAgent.Services
{
    public class PromptService
    {
        private readonly JsonFileRepository _repository = null;
        public PromptService(JsonFileRepository repository)
        {
            _repository = repository;
        }
        public async Task<PromptResponseMessage> ProcessPrompt(PromptRequestMessage request)
        {
            PayanarssApplication payanarssTypeApplication = new PayanarssApplication();
            PayanarssTypes types = payanarssTypeApplication.Types;

            foreach (var type in types) { 
                foreach(var column in type.Value.Children)
                {

                }
            }

            return await _repository.CreateJson(request);
        }
    }
}
