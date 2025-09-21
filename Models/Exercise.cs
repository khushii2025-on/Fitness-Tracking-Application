using Fitness_Tracking_Application.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness_Tracking_Application.Models
{
    public class Exercise
    {
        [Key]
        public int ExerciseId { get; set; }            

        [Required]
        [StringLength(100)]
        public string Name { get; set; }               

        [Range(0, 1000)]
        public int Reps { get; set; }                  

        [Range(0, 1000)]
        public int Sets { get; set; }                  

       
        [Range(0, 1000)]
        public double Weight { get; set; }

        
        [ForeignKey("Workout")]
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
    }
}

