# Dependency Injection Sample

```javascript
<TargetFramework>net7.0</TargetFramework>
```
## Usage
In Postman or Insomnia, calling 'localhost' and sending two different requests, looking up the IDs, and checking how the lifecycles work. 

#### First Request:
![First Request](https://i.imgur.com/YrS5yMJ.png)
#### Second Request:
![Second Request](https://imgur.com/C9LgGPM.png)

In .NET, Dependency Injection (DI) is a design pattern that allows you to decouple an object's creation and usage, making your application more modular and easier to maintain. When you use DI, the lifecycle of a dependency can be an important consideration.

### Singleton Lifecycle
```csharp
builder.Services.AddSingleton<SingletonService>();
```
A singleton is a dependency that is created once and used throughout the lifetime of the application. In the provided code, the SingletonService is added as a Singleton using the AddSingleton method. This means that the service will be created only once and will be reused every time it is requested by a consumer. This is useful for stateless services that can be shared across the entire application.


### Scoped Lifecycle
~~~csharp
builder.Services.AddScoped<ScopedService>();
~~~
A scoped dependency is created once per client request or connection. It will be reused within the same request, but not across multiple requests. In the provided code, the ScopedService is added as a Scoped dependency using the AddScoped method. This means that a new instance of the service will be created for each client request. This is useful for stateful services that need to maintain state within a request.

### Transient Lifecycle
~~~csharp
builder.Services.AddTransient<TransientService>();
~~~
A transient dependency is created each time it is requested. It is not shared across multiple requests or connections. In the provided code, the TransientService is added as a Transient dependency using the AddTransient method. This means that a new instance of the service will be created every time it is requested. This is useful for lightweight services that do not maintain any state and can be safely created multiple times.

By using these different lifecycle options, you can manage the creation and sharing of your dependencies more efficiently and effectively in your .NET application. 



