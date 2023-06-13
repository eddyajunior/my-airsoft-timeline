using AirsoftTimeline.Application.Contracts.Repositories;
using AirsoftTimeline.Application.Entidades;

namespace AirsoftTimeline.Application.Repositories
{
    public class OperationRepository : IOperationRepository
    {
        public Guid Add(OperationEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid guid)
        {
            throw new NotImplementedException();
        }

        public OperationEntity Get(Guid guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OperationEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(OperationEntity data)
        {
            throw new NotImplementedException();
        }
    }
}
