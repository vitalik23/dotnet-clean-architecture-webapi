using TaskManager.Domain.Enums;

namespace TaskManager.Application.Models.Tasks.Responses;

public class TaskResponse
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public TaskStatusEnum Status { get; set; }
}
