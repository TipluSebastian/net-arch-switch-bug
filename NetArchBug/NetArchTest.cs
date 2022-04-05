using Xunit;
using NetArchTest.Rules;
using Library;
using System;
using System.Linq;

namespace NetArchBug
{
    public class NetArchTest
    {
        [Fact]
        public void Test1()
        {
            var allowedDependencies = new[]
            {
                "System",
                "Library",
            };

            var result = Types.InAssembly(typeof(FailingLocalNameTranslator).Assembly)
                .Should()
                .OnlyHaveDependenciesOn(allowedDependencies)
                .GetResult();

            var failingTypes = (result.FailingTypeNames ?? Array.Empty<string>())
                .Select(typeName => Environment.NewLine + typeName);

            Assert.True(result.IsSuccessful, "Failing types:" + string.Concat(failingTypes));
        }
    }
}