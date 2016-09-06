using System.Threading;

namespace Elections.Server.Domain.Entities
{
    public class Grade
    {
        public int IdGrade { get; set; } 
        public string Description { get; set; }
        public string Lettle { get; set; }

        public Grade()
        {
            
        }

        public Grade(int idGrade, string description, string lettle)
        {
            IdGrade = idGrade;
            Description = description;
            Lettle = lettle;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}