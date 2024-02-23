using Bogus;
using ProjectOrganizer.Models;

namespace ProjectOrganizer.Data
{
    public class Faker
    {
        Faker<Project> projectModelFaker;

        public Faker() 
        {
            Randomizer.Seed = new Random(123);

            projectModelFaker = new Faker<Project>()
                .RuleFor(project => project.Id, faker => faker.Random.Int(1,10000))
                .RuleFor(project => project.Name, faker => faker.Name.JobTitle())
                .RuleFor(project => project.Description, faker => faker.Name.JobDescriptor())
                .RuleFor(project => project.Technologies, faker => faker.Name.JobType())
                ;
        }
    }
}