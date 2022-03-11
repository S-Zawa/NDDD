using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using System;

namespace NDDD.Infrastructure.Fake
{
    public class MeasureFake : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            return new MeasureEntity(10, Convert.ToDateTime("2012/12/12 12:34:56"), 12);
        }
    }
}
