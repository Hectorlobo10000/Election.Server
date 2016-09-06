using System;
using System.Windows.Forms;
using Elections.Server.Domain.Database;

namespace Elections.Server.Domain.Setup
{
    public class Connection
    {
        private readonly ISetup _setup;

        public Connection(ISetup setup)
        {
            _setup = setup;
        }

        public DataBase Open()
        {
            DataBase db = null;
            try
            {
                _setup.GetConnection().Open();
                var data = DataBase.Init(_setup.GetConnection(), 10);
                db = data;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            return db;
        }

        public void Close()
        {
            try
            {
                _setup.GetConnection().Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public ISetup GetConnection()
        {
            return _setup;
        }
    }
}