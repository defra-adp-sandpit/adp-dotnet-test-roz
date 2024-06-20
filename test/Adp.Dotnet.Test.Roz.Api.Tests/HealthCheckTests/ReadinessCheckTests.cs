using Adp.Dotnet.Test.Roz.Api.HealthChecks;

using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Adp.Dotnet.Test.Roz.Api.Tests.HealthChecksTests;

public class ReadinessCheckTests
{
    private readonly ReadinessCheck _sut = new();

    [Fact]
    public async Task CheckHealthAsync_Returns_Healthy()
    {
        //Arrange
        var mockContext = new HealthCheckContext();
        var cancellationToken = new CancellationToken();

        //Act
        var result = await _sut.CheckHealthAsync(mockContext, cancellationToken);

        //Assert
        result.Should().BeEquivalentTo(HealthCheckResult.Healthy("OK"));
    }
}