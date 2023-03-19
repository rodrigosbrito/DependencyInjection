namespace DependencyInjection.Services
{
    public class ScopedService
    {
        private readonly SingletonService _singletonService;

        public ScopedService(SingletonService singletonService) 
            => _singletonService = singletonService;

        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid SingletonServiceId => _singletonService.RequestId;    
    }
}
