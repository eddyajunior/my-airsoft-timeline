using AirsoftTimeline.Application.Contracts.Repositories;
using AirsoftTimeline.Application.Contracts.Services;
using AirsoftTimeline.Application.Entidades;
using AirsoftTimeline.Application.Validators;
using AirsoftTimeline.Application.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace AirsoftTimeline.Application.Services
{
    public class OperationService : IOperationService
    {
        private readonly IOperationRepository _operationRepository;

        public OperationService(IOperationRepository operationRepository)
        {
            _operationRepository = operationRepository;
        }

        public int Add(OperationEntity operation)
        {
            int result = 0;

            AddOperationValidator validator = new AddOperationValidator();
            //ValidationResult validation = validator.Validate(operation);

            try
            {
                var guid = _operationRepository.Add(operation);
                return 1;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public bool Delete(Guid operationId)
        {
            return _operationRepository.Delete(operationId);
        }

        public IEnumerable<OperationEntity> GetAll()
        {
            return _operationRepository.GetAll();
        }

        public OperationEntity GetById(Guid operationId)
        {
            return _operationRepository.Get(operationId);
        }

        public bool Update(OperationEntity operation)
        {
            return _operationRepository.Update(operation);
        }
    }
}
