using System;
using System.Collections.Generic;
using Elections.Server.Domain.Database;
using Elections.Server.Domain.Entities;
using Elections.Server.Domain.Setup;

namespace Elections.Server.Domain.Repositories
{
    public class SexRepository : ISexRepository
    {
        public List<Sex> GetAll()
        {
            var connec = new Connection(new Setup.Setup());
            connec.Open();
            var db = DataBase.Init(connec.GetConnection().GetConnection(), 20);
            var all = db.Sexes.All();
            connec.Close();
            return (List<Sex>)all;
        }
    }
}