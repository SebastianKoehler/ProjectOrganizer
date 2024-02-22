using ProjectOrganizer.Data;
using ProjectOrganizer.Interfaces;
using ProjectOrganizer.Models;

namespace ProjectOrganizer.Repositories
{
    public class ProjectRepository : IProjectRepository, IDisposable
    {
        private ProjectDbContext _dbContext;
        private bool disposed = false;

        public ProjectRepository(ProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Project> GetProjects()
        {
            return _dbContext.Projects.ToList();
        }

        public Project? GetProjectById(int id)
        {
            return _dbContext.Projects.Find(id);
        }

        public Project? GetProjectByName(string name)
        {
            return _dbContext.Projects.Find(name);
        }

        public void InsertProject(Project project)
        {
            _dbContext.Add(project);
        }

        public void UpdateProject(Project project)
        {
            _dbContext.Update(project);
        }

        public void DeleteProject(int id)
        {
            Project? project = _dbContext.Projects.Find(id);

            if (project != null)
            {
                _dbContext.Remove(project);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void SaveProject()
        {
            _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
