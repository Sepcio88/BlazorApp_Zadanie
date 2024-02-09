namespace BlazorApp.Models
{
    public class GroupM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Members { get; set; } = new List<User>();
        public GroupM(string name)
        {
            Name = name;
        }
    }
}
