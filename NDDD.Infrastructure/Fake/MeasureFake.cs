using NDDD.Domain;
using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using System;
using System.Linq;

namespace NDDD.Infrastructure.Fake
{
    internal sealed class MeasureFake : IMeasureRepository
    {

        public MeasureEntity GetLatest()
        {
            try
            {
                var data = CsvParser.Read<MeasureEntity>(Shared.FakePath + "MeasureFake.csv");
                return data.FirstOrDefault();
            }
            catch
            {
                return new MeasureEntity(10, Convert.ToDateTime("2012/12/12 12:34:56"), 12);
            }
        }
    }
}
