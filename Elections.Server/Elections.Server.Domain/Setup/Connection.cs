using System;
using System.Windows.Forms;

namespace Elections.Server.Domain.Setup
{
    public class Connection
    {
        private readonly ISetup _setup;

        public Connection(ISetup setup)
        {
            _setup = setup;
        }

        public void Open()
        {
            try
            {
                _setup.GetConnection().Open();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
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