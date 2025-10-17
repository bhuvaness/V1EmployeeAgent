using EmployeeDataAgent.DataModels;
using EmployeeDataAgent.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDataAgent.Controllers
{
    [Route("api/vi/EmployeeDataAgent/[controller]")]
    [ApiController]
    public class PromptController : ControllerBase
    {
        private readonly PromptService _service;
        public PromptController(PromptService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<PromptResponseMessage>> Prompt(PromptRequestMessage request)
        {
            var created = await _service.Prompt(request);
            return CreatedAtAction(nameof(created), new { id = created.Id }, created);
        }
    }
}
