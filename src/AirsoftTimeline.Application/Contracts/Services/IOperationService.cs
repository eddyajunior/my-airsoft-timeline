using AirsoftTimeline.Application.Entidades;

namespace AirsoftTimeline.Application.Contracts.Services
{
    public interface IOperationService
    {
        int Add(OperationEntity operation);
        bool Update(OperationEntity operation);
        bool Delete(Guid operationId);
        OperationEntity GetById(Guid operationId);
        IEnumerable<OperationEntity> GetAll();
    }
}
