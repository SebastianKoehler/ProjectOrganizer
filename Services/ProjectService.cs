using ProjectOrganizer.Interfaces;
using ProjectOrganizer.Models;
using ProjectOrganizer.Repositories;

namespace ProjectOrganizer.Services
{
    public class ProjectService : IProjectService
    {
        private readonly ProjectRepository _projectRepository;

        public ProjectService(ProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public IEnumerable<Project> GetProjects()
        {
            return _projectRepository.GetProjects();
        }

        public Project? GetProjectById(int id)
        {
            return _projectRepository.GetProjectById(id);
        }

        public Project? GetProjectByName(string name)
        {
            return _projectRepository.GetProjectByName(name);
        }

        public void InsertProject(Project project)
        {
            _projectRepository.InsertProject(project);
        }

        public void UpdateProject(Project project)
        {
            _projectRepository.UpdateProject(project);
        }

        public void DeleteProject(int id)
        {
            _projectRepository.DeleteProject(id);
        }

        public void SaveProject()
        {
           _projectRepository.SaveProject();
        }
    }
}
