using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;
//TODO: bu kısımda database bağlama işlemleri ve veri çekme işlemleri yapılacak
public class TaskDal : ITaskDal
{
    List<MyTask> _tasks;
    public TaskDal()
    {
        _tasks = new List<MyTask>();
        _tasks.Add(new MyTask { Id = 1, Title = "bugun yaptığım", CreatedDate = DateTime.Now, Description = "bugun yaptığım işler" });


    }
    public void Add(MyTask task)
    {
        _tasks.Add(task);
    }

    public List<MyTask> GetAll()
    {
        return _tasks;
    }
}