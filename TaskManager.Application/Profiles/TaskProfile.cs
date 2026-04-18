using AutoMapper;
using TaskManager.Application.Models.Tasks.Requests;
using TaskManager.Application.Models.Tasks.Responses;
using TaskManager.Domain.Entities;

namespace TaskManager.Application.Profiles;

public class TaskProfile : Profile
{
    public TaskProfile()
    {
        CreateMap<TaskItemEntity, TaskResponse>();
        CreateMap<CreateTaskRequest, TaskItemEntity>();
        CreateMap<UpdateTaskRequest, TaskItemEntity>();
    }
}
