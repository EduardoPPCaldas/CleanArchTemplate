using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace CleanApi.WebApi.Tests;

public class WebApiDependencyInjectionTests
{
    [Fact]
    public void ShouldInjectServicesCorrectly()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddWebApiServices();
        var serviceProvider = serviceCollection.BuildServiceProvider(validateScopes: true);
        
        serviceProvider.Should().NotBeNull();
    }
}