using System.Collections;
using Elections.Server.Domain.Entities;

namespace Elections.Server.Domain.Repositories
{
    public interface IRepository
    {
        ArrayList GetAllStaticFields();
        void InsertStudent(Student student);
    }
}