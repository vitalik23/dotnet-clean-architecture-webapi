using TaskManager.Domain.Enums;

namespace TaskManager.Application.Models.Tasks.Requests;

public class UpdateTaskRequest
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public TaskStatusEnum Status { get; set; }
}
