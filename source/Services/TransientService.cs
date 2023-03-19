namespace DependencyInjection.Services
{
    public record class TransientService
    {
        private readonly SingletonService _singletonService;
        private readonly ScopedService _scopedService;
        private readonly ScopedService _scopedServiceNewInstance;
        public TransientService(
            SingletonService singletonService, 
            ScopedService scopedService, 
            ScopedService scopedServiceNewInstance)
        {
            _singletonService = singletonService;
            _scopedService = scopedService;
            _scopedServiceNewInstance = scopedServiceNewInstance;
        }       

        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid SingletonServiceId => _singletonService.RequestId;
        public Guid ScopedServiceId => _scopedService.Id;
        public Guid SingletonServiceNewInstanceId => _scopedServiceNewInstance.Id;
    }
}
