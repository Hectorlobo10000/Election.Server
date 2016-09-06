namespace Elections.Server.Domain.Entities
{
    public class Sex
    {
        public int IdSex { get; set; }
        public string Description { get; set; }

        public Sex() 
        {
            
        }

        public Sex(int idSex, string description)
        {
            IdSex = idSex;
            Description = description;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}