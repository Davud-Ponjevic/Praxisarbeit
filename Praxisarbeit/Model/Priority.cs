﻿using System.ComponentModel.DataAnnotations;

namespace Praxisarbeit.Model
{
    public class Priority
    {
        [Key]
        public int PriorityID { get; set; }

        [Required]
        public string PriorityType { get; set; }

        [Required]
        public int DaysToCompletion { get; set; }
    }
}
