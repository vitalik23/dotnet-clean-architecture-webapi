using TaskManager.Application.Abstractions;
using TaskManager.Domain.Entities;
using TaskManager.Infrastructure.Persistence;

namespace TaskManager.Infrastructure.Repositories;

public class TaskRepository(AppDbContext context): GenericRepository<TaskItemEntity>(context), ITaskRepository { }
