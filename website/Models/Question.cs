using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Website.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        public string QuestionText { get; set; }
        [Required]
        public int Marks { get; set; }
        [Required]
        public int CorrectOptionId { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public QuestionCategory Category { get; set; }
    }
}
