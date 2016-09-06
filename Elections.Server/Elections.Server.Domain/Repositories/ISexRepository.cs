using System.Collections.Generic;
using Elections.Server.Domain.Entities;

namespace Elections.Server.Domain.Repositories
{
    public interface ISexRepository
    {
        List<Sex> GetAll();
    }
}