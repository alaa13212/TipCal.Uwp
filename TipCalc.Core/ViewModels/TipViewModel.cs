using MvvmCross.ViewModels;
using System.Threading.Tasks;
using TipCalc.Core.Services;

namespace TipCalc.Core.ViewModels
{
	public class TipViewModel : MvxViewModel
	{
		private readonly ICalculationService _calculationService;

		public TipViewModel(ICalculationService calculationService)
		{
			_calculationService = calculationService;
		}

		public override async Task Initialize()
		{
			await base.Initialize();


		}

		private double _subTotal;
		public double SubTotal
		{
			get => _subTotal;
			set => SetProperty(ref _subTotal, value, Recalculate);
		}

		private int _generosity;
		public int Generosity
		{
			get => _generosity;
			set => SetProperty(ref _generosity, value, Recalculate);
		}

		private double _tip;
		public double Tip 
		{
			get => _tip;
			set { SetProperty(ref _tip, value); }
		}


		private void Recalculate()
		{
			Tip = _calculationService.TipAmount(SubTotal, Generosity);
		}
	}
}
