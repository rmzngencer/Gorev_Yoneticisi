using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class MyTask:BaseEntity<int>
{
    
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime daneDate { get; set; }

    
}