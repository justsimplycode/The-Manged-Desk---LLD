using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrack_LLD.Model
{
    public class Task
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public Priority Priority { get; set; }

        public Status Status { get; set; }

        public User Assignee { get; set; }

        public Task(int id, string title, string description, Priority priority, Status status)
        {
            Id = id;
            Title = title;
            Description = description;
            Priority = priority;
            Status = status;
        }

        public void UpdateTask(string title, string description, Priority priority, Status status)
        {
            Title = title;
            Description = description; 
            Priority = priority; 
            Status = status;
        }

        public void AssignToUser(User user)
        {
            Assignee = user;
            user.AssignedTasks.Add(this);
        }
    }

    public enum Priority
    {
        High = 1,
        Medium = 2,
        Low = 3
    }

    public enum Status
    {
        NotStarted = 1,
        InProgress = 2,
        Completed = 3
    }
}
