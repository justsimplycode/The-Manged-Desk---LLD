using StaffTrack_LLD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = StaffTrack_LLD.Model.Task;

namespace StaffTrack_LLD.Repository
{
    public interface ITaskManager
    {
        public User CreateUser(int userId, string userName);

        public Project CreateProject(int projectid, string projectName);

        public Task CreateTask(int taskId, string title, string description, Priority priority, Status status, Project project);

        public void UpdateTask(string title, string description, Priority priority, Status status, Task task);

        public void DeleteTask(Task task, Project project);

        public void AssignTask(Task task, User user);

        public void GetAllTasks(Project project);
    }
}
