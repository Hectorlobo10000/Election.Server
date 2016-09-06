using Dapper;
using Elections.Server.Domain.Entities;

namespace Elections.Server.Domain.Database
{
    public class DataBase : Database<DataBase>
    {
         public Table<Student> Students { get; set; }
         public Table<Sex> Sexes { get; set; }
    }
}