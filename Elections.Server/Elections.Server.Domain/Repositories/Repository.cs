using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Elections.Server.Domain.Entities;
using Elections.Server.Domain.Setup;

namespace Elections.Server.Domain.Repositories
{
    public class Repository : IRepository
    {
        private readonly Connection _connection = new Connection(new Setup.Setup());

        public ArrayList GetAllStaticFields()
        {
            var list = new ArrayList();

            var db = _connection.Open();
            var allSexes = db.Sexes.All();
            var allGrades = db.Grades.All();
            var allSections = db.Sections.All();
            _connection.Close();

            list.Add(((List<Sex>)allSexes).ToArray());
            list.Add(((List<Grade>)allGrades).ToArray());
            list.Add(((List<Section>)allSections).ToArray());

            return list;
        }

        public void InsertStudent(Student student)
        {
            var db = _connection.Open();
            try
            {
                db.Students.Insert(student);
                MessageBox.Show("Registrado");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            _connection.Close();

        }
    }
}