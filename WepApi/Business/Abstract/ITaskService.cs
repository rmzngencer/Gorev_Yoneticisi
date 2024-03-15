﻿﻿using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface ITaskService
{
    public Task<List<GetAllTaskResponse>> GetAllAsync();
    CreatedTaskResponse Add(CreateTaskRequest createBrandRequest);
   
}
//responses and requests