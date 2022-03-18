using NDDD.Domain;
using NDDD.Domain.Entities;
using NDDD.Domain.Exceptions;
using NDDD.Domain.Repositories;
using System;
using System.Collections.Generic;
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
        public IReadOnlyList<MeasureEntity> GetLatests()
        {
            var result = new List();
            result.Add(
                new MeasureEntity(
                    10,
                    Convert.ToDateTime("2020/12/12 12:34:56"),
                    123.341f));

            result.Add(
              new MeasureEntity(
                  20,
                  Convert.ToDateTime("2020/12/12 12:34:56"),
                  223.341f));
            result.Add(
              new MeasureEntity(
                  30,
                  Convert.ToDateTime("2020/12/12 12:34:56"),
                  323.341f));

            return result;
        }
    }
}