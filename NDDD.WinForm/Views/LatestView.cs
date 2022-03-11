using NDDD.Infrastructure;
using NDDD.WinForm.ViewModels;
using System;
using System.Windows.Forms;

namespace NDDD.WinForm.Views
{
    public partial class LatestView : Form
    {
        private LatestViewModel _viewModel = new LatestViewModel(Factories.CreateMeasure());
        public LatestView()
        {
            InitializeComponent();

            AreaIdTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.AreaIdText));
            MeasureDateTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.MeasureDateText));
            MeasureValueTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.MeasureValueText));
        }




        private void SearchButton_Click(object sender, EventArgs e)
        {
            _viewModel.Search();
        }
    }
}
