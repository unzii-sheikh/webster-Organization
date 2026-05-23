using System.ComponentModel.DataAnnotations;

namespace Website.Models
{
    public class QuestionCategory
    {
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public int TotalMarks { get; set; }
        [Required]
        public int PassingMarks { get; set; }
    }
}
