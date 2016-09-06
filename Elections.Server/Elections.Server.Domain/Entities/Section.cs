namespace Elections.Server.Domain.Entities
{
    public class Section
    {
        public int IdSection { get; set; }
        public string Description { get; set; }

        public Section()
        {
            
        }

        public Section(int idSection, string description)
        {
            IdSection = idSection;
            Description = Description;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}