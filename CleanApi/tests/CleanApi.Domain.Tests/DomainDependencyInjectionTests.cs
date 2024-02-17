using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace CleanApi.Domain.Tests;

public class DomainDependencyInjectionTests
{
    [Fact]
    public void ShouldInjectServicesCorrectly()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddDomainServices();
        var serviceProvider = serviceCollection.BuildServiceProvider(validateScopes: true);
        
        serviceProvider.Should().NotBeNull();
    }
}