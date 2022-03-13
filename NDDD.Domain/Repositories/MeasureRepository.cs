using NDDD.Domain.Entities;
using NDDD.Domain.Exceptions;
using System.Threading;

namespace NDDD.Domain.Repositories
{
    public sealed class MeasureRepository
    {
        private IMeasureRepository _measureRepository;

        public MeasureRepository(IMeasureRepository repository)
        {
            _measureRepository = repository;
        }

        public MeasureEntity GetLatest()
        {
            var val1 = _measureRepository.GetLatest();
            if (val1 == null)
            {
                throw new DataNotExistsException();
            }
            Thread.Sleep(1000);
            var val2 = _measureRepository.GetLatest();
            Thread.Sleep(1000);
            var val3 = _measureRepository.GetLatest();
            Thread.Sleep(1000);

            var val = (val1.MeasureValue.Value + val2.MeasureValue.Value + val3.MeasureValue.Value) / 3;

            return new MeasureEntity(val3.AreaId.Value, val3.MeasureDate.Value, val);
        }
    }
}