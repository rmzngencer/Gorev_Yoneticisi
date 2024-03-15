
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ITaskDal
{
    public Task AddAsync(MyTask task);
    
    public Task<List<MyTask>> GetAllAsync();
}

