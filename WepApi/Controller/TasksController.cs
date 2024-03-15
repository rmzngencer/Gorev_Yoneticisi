using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(CreateTaskRequest createTaskRequest)
        {
           CreatedTaskResponse createdTaskResponse =  _taskService.Add(createTaskRequest);

           return Ok(createdTaskResponse);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            return Ok(_taskService.GetAllAsync());
        }
    }
}