using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Website.Models
{
    public class Candidatetest
    {
        public int Id { get; set; }
        [Required]
        public string TestStatus { get; set; }
        [Required]
        public DateTime StartingTime { get; set; } = DateTime.Now;

        public DateTime EndingTime { get; set; } = DateTime.Now;

        public int CandidateId { get; set; }
        [ForeignKey("CandidateId")]
        public Candidate Candidate { get; set; }
    }
}
