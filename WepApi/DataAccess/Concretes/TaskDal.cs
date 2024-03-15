using DataAccess.Abstracts;
using Entities.Concretes;
using MongoDB.Driver;
using DataAccess.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace DataAccess.Concretes;
//TODO: bu kısımda database bağlama işlemleri ve veri çekme işlemleri yapılacak
public class TaskDal : ITaskDal
{
   
    private readonly IMongoCollection<MyTask> productCollection;
    public TaskDal(
         IOptions <mongoDBSettings> taskDatabaseSetting)
        {
            var mongoClient = new MongoClient(
                taskDatabaseSetting.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(
                taskDatabaseSetting.Value.DatabaseName);
            productCollection = mongoDatabase.GetCollection<MyTask>(
                "Tasks");
        }
    public async Task AddAsync(MyTask task)
    {
       await productCollection.InsertOneAsync(task);
    }

    public async Task<List<MyTask>> GetAllAsync()
    {
         return await productCollection.Find(_ => true).ToListAsync();
    }
}