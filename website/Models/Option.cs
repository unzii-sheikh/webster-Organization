using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Website.Models
{
    public class Option
    {
        public int Id { get; set; }
        [Required]
        public string OptionText { get; set; }
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public Question question { get; set; }

    }
}
