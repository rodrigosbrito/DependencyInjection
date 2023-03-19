namespace DependencyInjection.Services
{
    public class SingletonService
    {
        public Guid RequestId { get; set; } = Guid.NewGuid();
    }
}
