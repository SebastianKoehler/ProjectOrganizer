using ProjectOrganizer.Models;

namespace ProjectOrganizer.Interfaces
{
    public interface IProjectService
    {
        IEnumerable<Project> GetProjects();
        Project? GetProjectById(int id);
        Project? GetProjectByName(string name);
        void InsertProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(int id);
        void SaveProject();
    }
}
