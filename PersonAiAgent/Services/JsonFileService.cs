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
        public async Task<PromptResponseMessage> Prompt(PromptRequestMessage request)
        {
            return await _repository.CreateJson(request);
        }
    }
}
