using AirsoftTimeline.Application.Entidades;
using AirsoftTimeline.Application.ValueObjects;

namespace AirsoftTimeline.Tests.Helpers
{
    public static class OperationHelper
    {
        public static OperationEntity GenerateOperation(string name, string place, List<TeamVO> teamsList, Application.Enums.OperationType operationType)
        {
            return new OperationEntity(
                new Application.ValueObjects.OperationVO
                {
                    Date = DateTime.Now,
                    Name = name,
                    Place = place,
                    Teams = teamsList,
                    Type = operationType
                });
        }

        public static IEnumerable<TeamVO> GenerateTeamList(int qtd)
        {
            var teamsList = new List<TeamVO>();

            for (int i = 1; i <= qtd; i++)
            {
                teamsList.Add(new TeamVO { Name = $"Team {i}", Patch = $"team{i}.png" });
            }

            return teamsList;
        }
    }
}
