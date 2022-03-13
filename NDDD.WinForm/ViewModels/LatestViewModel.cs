using NDDD.Domain.Repositories;
using NDDD.Infrastructure;

namespace NDDD.WinForm.ViewModels
{
    public class LatestViewModel : ViewModelBase
    {
        public readonly MeasureRepository _measureRepository;

        private string _areaIdText = string.Empty;
        private string _measureDateText = string.Empty;
        private string _measureValueText = string.Empty;

        public LatestViewModel() : this(Factories.CreateMeasure())
        {
        }

        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = new MeasureRepository(measureRepository);
        }

        public string AreaIdText
        {
            get
            {
                return _areaIdText;
            }
            set
            {
                SetProperty(ref _areaIdText, value);
            }
        }

        public string MeasureDateText
        {
            get
            {
                return _measureDateText;
            }
            set
            {
                SetProperty(ref _measureDateText, value);
            }
        }

        public string MeasureValueText
        {
            get
            {
                return _measureValueText;
            }
            set
            {
                SetProperty(ref _measureValueText, value);
            }
        }

        public void Search()
        {
            var measure = _measureRepository.GetLatest();
            AreaIdText = measure.AreaId.DisplayValue;
            MeasureDateText = measure.MeasureDate.DisplayValue;
            MeasureValueText = measure.MeasureValue.DisplayValue;
        }
    }
}