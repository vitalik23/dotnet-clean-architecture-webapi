using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.Services;
using TaskManager.Application.Models.Tasks.Requests;
using TaskManager.Application.Models.Tasks.Responses;

namespace TaskManager.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController(TaskService taskService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<TaskResponse>> Create(CreateTaskRequest request)
    {
        var result = await taskService.CreateAsync(request);
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult<TaskResponse>> Update(UpdateTaskRequest request)
    {
        var result = await taskService.UpdateAsync(request);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TaskResponse>> GetById(Guid id)
    {
        var result = await taskService.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await taskService.DeleteAsync(id);
        return NoContent();
    }

    [HttpGet]
    public async Task<ActionResult<List<TaskResponse>>> GetAll()
    {
        var result = await taskService.GetAllAsync();
        return Ok(result);
    }
}
