using AirsoftTimeline.Application.ValueObjects;

namespace AirsoftTimeline.Application.Entidades
{
    public class OperationEntity
    {
        public OperationEntity(OperationVO operation)
        {
            Identifier = Guid.NewGuid();
            Operation = operation;
            CreatedAt = DateTime.UtcNow;
        }

        public bool ValidateDate(OperationVO operation)
        {
            DateTime dateTemp;

            if (DateTime.TryParse(operation.Date.ToString(), out dateTemp)) 
            { 
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateName(OperationVO operation)
        {
            return string.IsNullOrEmpty(operation.Name);
        }

        public bool ValidatePlace(OperationVO operation)
        {
            return string.IsNullOrEmpty(operation.Place);
        }

        public bool AddNewTeam(TeamVO team)
        {
            var teamExists = TeamExists(team);

            if (teamExists != null)
            {
                return false;
            }

            Operation.Teams.Add(team);
            return true;
        }

        public TeamVO? TeamExists(TeamVO team)
        {
            return Operation.Teams.Find(x => x.Name == team.Name);
        }

        public void SetUpdateDate()
        {
            UpdatedAt = DateTime.UtcNow;
        }

        public Guid Identifier { get; private set; }
        public OperationVO Operation { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}
