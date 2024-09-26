using System.ComponentModel.DataAnnotations.Schema;

namespace TechApp.Entites
{
    public class CategoryItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int MediaTypeId {  get; set; }
        public DateTime DateTimeReleased {  get; set; }

        
    }
}
