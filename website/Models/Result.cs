using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Website.Models
{
    public class Result
    {
        public int Id { get; set; }
        [Required]
        public int TotalMarks { get; set; }
        [Required]
        public int ObtainedMarks { get; set; }
        [Required]
        public decimal Percentage { get; set; }
        [Required]
        public string ResultStatus { get; set; }
        [Required]
        
    public DateTime ResultDate { get; set; } = DateTime.Now;

     public int CandidateTestId { get; set; }
        [ForeignKey("CandidateTestId")]
        public Candidatetest Candidatetest { get; set; }
    }
}
