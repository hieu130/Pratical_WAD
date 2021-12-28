using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical_WAD.Models
{
    public class Exam   
    {
        public int Id { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string StartTime { get; set; }
        [Required]
        public DateTime ExamDate { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string ClassRoom { get; set; }
        [Required]
        public string Factulty { get; set; }
        [Required]
        public string Status { get; set; }
    }
}