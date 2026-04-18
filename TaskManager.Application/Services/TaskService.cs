using AutoMapper;
using TaskManager.Application.Abstractions;
using TaskManager.Application.Common.Exceptions;
using TaskManager.Application.Models.Tasks.Requests;
using TaskManager.Application.Models.Tasks.Responses;
using TaskManager.Domain.Entities;

namespace TaskManager.Application.Services;

public class TaskService(ITaskRepository taskRepository, IMapper mapper)
{
    public async Task<TaskResponse> CreateAsync(CreateTaskRequest request)
    {
        var entity = mapper.Map<TaskItemEntity>(request);
        await taskRepository.CreateAsync(entity);
        await taskRepository.SaveChangesAsync();
        return mapper.Map<TaskResponse>(entity);
    }

    public async Task<TaskResponse> UpdateAsync(UpdateTaskRequest request)
    {
        var originalTaskItem = await taskRepository.GetByIdAsync(request.Id);

        if (originalTaskItem is null)
            throw new NotFoundException("Task was not found!");

        if (originalTaskItem.Title != request.Title)
            originalTaskItem.Title = request.Title;

        if (originalTaskItem.Description != request.Description)
            originalTaskItem.Description = request.Description;

        if (originalTaskItem.Status != request.Status)
            originalTaskItem.Status = request.Status;

        originalTaskItem.Updated = DateTime.UtcNow;

        taskRepository.Update(originalTaskItem);
        await taskRepository.SaveChangesAsync();

        return mapper.Map<TaskResponse>(originalTaskItem);
    }

    public async Task<TaskResponse> GetByIdAsync(Guid id)
    {
        var taskItem = await taskRepository.GetByIdAsync(id);

        if (taskItem is null)
            throw new NotFoundException("Task was not found!");

        return mapper.Map<TaskResponse>(taskItem);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var taskItem = await taskRepository.GetByIdAsync(id);

        if (taskItem is null)
            throw new NotFoundException("Task was not found!");

        taskRepository.Delete(taskItem);
        return await taskRepository.SaveChangesAsync();
    }

    public async Task<List<TaskResponse>> GetAllAsync()
    {
        var taskItems = await taskRepository.GetAllAsync() ?? new List<TaskItemEntity>();
        return mapper.Map<List<TaskResponse>>(taskItems);
    }
}
