
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ITaskDal
{
    void Add(MyTask task);
    List<MyTask> GetAll();
}

