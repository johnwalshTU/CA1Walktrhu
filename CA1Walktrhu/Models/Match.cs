using System.ComponentModel.DataAnnotations;

namespace CA1Walktrhu.Models
{
    public class Match
    {
        public int MatchID { get; set; }

        public DateTime MatchDate { get; set; }

        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Opponent { get; set; } = "";

        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Venue { get; set; } = "";


        [Display(Name = "Goals For")]
        [Range(0, 100, ErrorMessage = "Max number of goals allowed is 100")]
        public int? GoalsFor { get; set; }

        [Display(Name = "Goals For")]
        [Range(0, 100, ErrorMessage = "Max number of goals allowed is 100")]
        public int? GoalAgainst { get; set; }
    }
}
