public class JobRepository
{
    public async Task<IEnumberable<JobDto>> GetJoblistAsync()
    {
    
        {
            return new List<JobDto>
        {
            new JobDto { Id = 1, Name = "Software Engineer", Description = "Develop and maintain software applications" },
            new JobDto { Id = 2, Name = "Product Manager", Description = "Manage product development and strategy" }
        };
            
        }
        return jobList;
    }
}