using NDDD.Domain;
using NDDD.Domain.Entities;
using NDDD.Domain.Exceptions;
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
            catch (Exception ex)
            {
                throw new FakeException("MeasureFakeの取得に失敗しました", ex); ;
            }
        }
    }
}