using TaskManager.Domain.Entities;

namespace TaskManager.Application.Abstractions;

public interface ITaskRepository : IGenericRepository<TaskItemEntity> { }
