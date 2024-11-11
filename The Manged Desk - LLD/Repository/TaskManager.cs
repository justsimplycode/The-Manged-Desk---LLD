using StaffTrack_LLD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = StaffTrack_LLD.Model.Task;

namespace StaffTrack_LLD.Repository
{
    public class TaskManager : ITaskManager
    {
        private List<Project> _projects;

        private List<User> _users;

        public TaskManager()
        {
            _projects = new List<Project>();
            _users = new List<User>();
        }

        public User CreateUser(int userId, string userName)
        {
            User user = new User(userId, userName);
            _users.Add(user);

            return user;
        }

        public Project CreateProject(int projectid, string projectName)
        {
            Project project = new Project(projectid, projectName);
            _projects.Add(project);

            return project;
        }

        public Task CreateTask(int taskId, string title, string description, Priority priority, Status status, Project project)
        {
            Task task = new Task(taskId, title, description, priority, status);
            project.AddTask(task);

            return task;
        }

        public void UpdateTask(string title, string description, Priority priority, Status status, Task task)
        {
            task.UpdateTask(title, description, priority, status);
        }

        public void DeleteTask(Task task, Project project)
        {
            project.DeleteTask(task);
        }

        public void GetAllTasks(Project project)
        {
            Console.WriteLine($"Tasks for Project: {project.Name}");

            foreach (Task task in project.Tasks)
            {
                string assigneeName = task.Assignee?.Name ?? "Unassigned";
                Console.WriteLine($"- Task ID: {task.Id}, Title: {task.Title}, Description: {task.Description}, Status: {task.Status}, Priority: {task.Priority}, Assignee: {assigneeName}");
            }
        }

        public void AssignTask(Task task, User user)
        {
            task.AssignToUser(user);
        }
    }
}
