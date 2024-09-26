using System.ComponentModel.DataAnnotations.Schema;

namespace TechApp.Entites
{
    public class UserCategory
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CategoryId { get; set; }
        
    }
}
