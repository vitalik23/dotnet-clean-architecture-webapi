using TaskManager.Domain.Entities.Base;
using TaskManager.Domain.Enums;

namespace TaskManager.Domain.Entities;

public class TaskItemEntity : IBaseEntity
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime Updated { get; set; }

    public required string Title { get; set; }
    public string? Description { get; set; }
    public TaskStatusEnum Status { get; set; }
}
