using System.ComponentModel.DataAnnotations;
using dts_challenge_backend.Data;

namespace dts_challenge_backend.Data
{
    public class CaseTask
    {
        public CaseTask() { }

        public CaseTask(int id, string title, string? description, TaskStatus status, DateTime dueDate) 
        {
            Id = id;
            Title = title;
            Description = description;
            Status = status;
            DueDate = dueDate;
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        [Required]
        public TaskStatus Status { get; set; }

        [Required]
        public DateTime DueDate { get; set; }
    }
}
