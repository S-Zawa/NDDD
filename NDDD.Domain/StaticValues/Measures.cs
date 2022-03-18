using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Domain.ValueObjects;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NDDD.Domain.StaticValues
{
    public class Measures
    {
        private static List<MeasureEntity> _entities = new List<MeasureEntity>();

        public static void Create(IMeasureRepository repository)
        {
            lock (((ICollection)_entities).SyncRoot)
            {
                _entities.Clear();
                _entities.AddRange(repository.GetLatests());
            }
        }
        public static MeasureEntity GetLatest(AreaId areaId)
        {
            lock (((ICollection)_entities).SyncRoot)
            {
                return _entities.FirstOrDefault(x => x.AreaId == areaId);
            }
        }
    }
}
