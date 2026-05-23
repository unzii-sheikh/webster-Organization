using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Website.Models
{
    public class CandidateAnswer
    {
        public int Id { get; set; }
        [Required]
        public int MarksObtained { get; set; }
        [Required]
        public Boolean IsCorrect { get; set; }

        public int CandidateTestId { get; set; }
        [ForeignKey("CandidateTestId")]
        public Candidatetest candidatetest { get; set; }

        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
        public int OptionId { get; set; }
        [ForeignKey("OptionId")]
        public Option option { get; set; }


    }
}
