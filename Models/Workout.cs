using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fitness_Tracking_Application.Models
{
    public class Workout
    {
        [Key]
        public int WorkoutId { get; set; }              

        [Required]
        [StringLength(100)]
        public string Title { get; set; }               

        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.UtcNow;

        [Range(1, 600)]
        public int DurationMinutes { get; set; }        

        
        public ICollection<Exercise> Exercises { get; set; }
    }
}

