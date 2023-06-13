using AirsoftTimeline.Application.Contracts.Repositories;
using AirsoftTimeline.Application.Entidades;
using AirsoftTimeline.Application.Enums;
using AirsoftTimeline.Application.Services;
using AirsoftTimeline.Application.ValueObjects;
using AirsoftTimeline.Tests.Helpers;
using Moq;

namespace AirsoftTimeline.Tests.Units.Services
{
    public class OperationServiceTests
    {
        [Fact]
        public void Should_Be_Return_0()
        {
            // Arrange 
            Mock<IOperationRepository> mock = new Mock<IOperationRepository>();
            mock.Setup(x => x.Add(It.IsAny<OperationEntity>())).Returns(Guid.NewGuid());

            var service = new OperationService(mock.Object);

            var teamsList = OperationHelper.GenerateTeamList(3).ToList();
            OperationEntity entity = OperationHelper.GenerateOperation("Operation Mock", "Araçariguama", teamsList, OperationType.TeamMatch);

            // Act 
            var result = service.Add(entity);

            // Assert
            Assert.True(result > 0);
        }

        [Fact]
        public void Should_Be_Return_1()
        {
            // Arrange 
            Mock<IOperationRepository> mock = new Mock<IOperationRepository>();
            mock.Setup(x => x.Add(It.IsAny<OperationEntity>())).Returns(Guid.NewGuid());

            var service = new OperationService(mock.Object);

            var teamsList = OperationHelper.GenerateTeamList(3).ToList();
            OperationEntity entity = OperationHelper.GenerateOperation("Operation Mock", "Araçariguama", teamsList, OperationType.TeamMatch);

            // Act 
            var result = service.Add(entity);

            // Assert
            Assert.True(result > 0);
        }


    }
}
