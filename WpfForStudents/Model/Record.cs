namespace WpfForStudents.Models
{
    public class Record
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public Record(int id, string name, string description, string Type) 
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Type = Type;
        }
    }
}