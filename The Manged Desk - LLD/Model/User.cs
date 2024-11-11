using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrack_LLD.Model
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Task> AssignedTasks { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
            AssignedTasks = new List<Task>();
        }
    }
}
