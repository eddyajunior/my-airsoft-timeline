using AirsoftTimeline.Application.Entidades;

namespace AirsoftTimeline.Application.Contracts.Repositories
{
    public interface IOperationRepository
    {
        Guid Add(OperationEntity entity);
        bool Update(OperationEntity data);
        bool Delete(Guid guid);
        OperationEntity Get(Guid guid);
        IEnumerable<OperationEntity> GetAll();
    }
}
