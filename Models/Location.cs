namespace DemirbasYonetim.Models
{
    public class Location
    {
        public int Id { get; set; }
        // string? yaparak "Burası boş geçilebilir" diyoruz
        public string? DepartmentName { get; set; }
        public string? Floor { get; set; }
    }
}