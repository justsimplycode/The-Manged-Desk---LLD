using StaffTrack_LLD.Model;
using StaffTrack_LLD.Repository;
using Task = StaffTrack_LLD.Model.Task;

namespace StaffTrack_LLD
{
    public class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            User user1 = taskManager.CreateUser(1, "shaswat");
            User user2 = taskManager.CreateUser(2, "shubham");

            Project project = taskManager.CreateProject(101, "Task Management");

            Task task1 = taskManager.CreateTask(1001, "Design Architecture", "Design the system architecture.", Priority.High, Status.NotStarted, project);
            Task task2 = taskManager.CreateTask(1002, "Set Up CI/CD", "Implement CI/CD pipelines.", Priority.Medium, Status.NotStarted, project);

            taskManager.AssignTask(task2, user1);
            taskManager.AssignTask(task1, user2);

            taskManager.GetAllTasks(project);

            taskManager.UpdateTask(task1.Title, task1.Description, task1.Priority, Status.InProgress, task1);

            taskManager.DeleteTask(task2, project);

            taskManager.GetAllTasks(project);
        }
    }
}
