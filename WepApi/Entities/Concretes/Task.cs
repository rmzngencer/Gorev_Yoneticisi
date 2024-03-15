using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Entities.Concretes;

public class MyTask:BaseEntity<int>
{
    [BsonElement("Title")]
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime daneDate { get; set; }

    
}