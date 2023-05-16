namespace ConsumeAPI.Model
{
    public class Pokemon
    {

        public int base_experience { get; set; }
        public int height { get; set; }
        public int id { get; set; }
        public bool is_default { get; set; }
        public string? name { get; set; }
        public int order { get; set; }
        public Sprite? sprites { get; set; }
        public int weight { get; set; }
    }
}