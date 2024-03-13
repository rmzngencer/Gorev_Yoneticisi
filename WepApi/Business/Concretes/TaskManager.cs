﻿using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class TasksManager : ITaskService
{
    private readonly ITaskDal _taskDal;

    public TasksManager(ITaskDal taskDal)
    {
        _taskDal = taskDal;
    }

    public CreatedTaskResponse Add(CreateTaskRequest createTaskRequest)
    {

        //business rules

        //mapping -->automapper
        MyTask task = new();
        task.Title = createTaskRequest.Title;
        task.CreatedDate = DateTime.Now;
        
        _taskDal.Add(task);

        //mapping
        CreatedTaskResponse createdBrandResponse = new CreatedTaskResponse();
        createdBrandResponse.Title = task.Title;
        createdBrandResponse.Id = 4;
        createdBrandResponse.CreatedDate = task.CreatedDate;

        return createdBrandResponse;
    }

    
    public List<GetAllTaskResponse> GetAll()
    {
        List<MyTask> tasks = _taskDal.GetAll();

        List<GetAllTaskResponse> getAllTaskResponses = new List<GetAllTaskResponse>();

        foreach (var task in tasks)
        {
            GetAllTaskResponse getAllTaskResponse = new GetAllTaskResponse();
            getAllTaskResponse.Title = task.Title;
            getAllTaskResponse.Id = task.Id;
            getAllTaskResponse.CreatedDate = task.CreatedDate;

            getAllTaskResponses.Add(getAllTaskResponse);
        }

        return getAllTaskResponses;
    }

   
}