# Low-Level Design
![Screenshot 2024-11-11 214554](https://github.com/user-attachments/assets/f29724ef-bdc4-48e7-978d-acc5fce646f1)




# The Managed Desk

The Managed Desk is a Task Management System which is a console-based application built in C#. It allows users to manage tasks within projects by creating, assigning, updating, and tracking tasks. It’s designed with modular classes for efficient task and user management, ensuring a flexible and extendable structure.

## Key Features

1. **User Management**: Register users who can be assigned tasks.
2. **Task Management**: Create tasks, set priorities, and track statuses (ToDo, InProgress, Completed).
3. **Project Management**: Organize tasks under projects to keep track of related work items.
4. **Task Assignment**: Assign tasks to specific users and update task status as needed.
5. **Project Overview**: View all tasks within a project along with their current status and assigned user.

## System Structure

The project is designed with distinct classes for key functionalities:

- **User**: Represents a user, including ID, name, and tasks assigned to them.
- **Task**: Defines task properties like ID, title, description, priority, status, and assignee.
- **Project**: Contains tasks related to a specific project, helping organize and track tasks within a single context.
- **TaskManager**: Acts as the controller, managing users, tasks, and projects, and handling actions like task creation, assignment, and status updates.

## How to Use

1. **Setup**:
   - Create users and projects using the `TaskManager`.
   - Add tasks to a project, specifying the title, description, and priority level.

2. **Assign Tasks**:
   - Tasks can be assigned to users by linking a `User` object to a `Task` via the `TaskManager`.

3. **Update Task Status**:
   - Change a task's status from ToDo to InProgress or Completed, depending on progress.

4. **Project Overview**:
   - The `TaskManager` provides a summary of all tasks within a project, showing details like task title, priority, status, and assignee.

## Example Usage

```csharp
var taskManager = new TaskManager();

// Create users and projects
var user1 = taskManager.CreateUser(1, "Alice");
var project1 = taskManager.CreateProject(101, "Project Alpha");

// Add tasks to the project
var task1 = taskManager.CreateTask(1001, "Design System", "Outline the architecture.", TaskPriority.High, project1);
var task2 = taskManager.CreateTask(1002, "Setup CI/CD", "Implement pipelines.", TaskPriority.Medium, project1);

// Assign tasks to users
taskManager.AssignTaskToUser(task1, user1);

// Update task status
taskManager.UpdateTaskStatus(task1, TaskStatus.InProgress);

// Display project tasks
taskManager.DisplayProjectTasks(project1);
