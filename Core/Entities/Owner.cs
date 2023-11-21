namespace Core.Entities
{
    public class Owner : EntityBase
    {
        public string FullName { get; set; }

        
        public string Picture { get; set; }

        
        public string Headline { get; set; }

        public Address Address { get; set; }

    }

}
