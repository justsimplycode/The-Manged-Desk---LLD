using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrack_LLD.Model
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Task> Tasks { get; set; }

        public Project(int id, string name)
        {
            Id = id;
            Name = name;
            Tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public void DeleteTask(Task task) 
        { 
            Tasks.Remove(task);
        }
    }
}
