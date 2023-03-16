//done

namespace _Developer
{
    public class DeveloperContent
    {
        public string Name { get; set; }
        public double Id { get; set; }
        public bool PluralSight { get; set; }

        public DeveloperContent() {}

        public DeveloperContent(string name)
        {
            Name = name;
        }
        public DeveloperContent(string name, double id, bool pluralSight)
        {
            Name = name;
            Id = id;
            PluralSight = pluralSight;
        }
    }
}