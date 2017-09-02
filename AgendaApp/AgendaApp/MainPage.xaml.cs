using OxyPlot.Series;
using OxyPlot.Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgendaApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			//InitializeComponent();
			OxyPlot.PlotModel Model = new OxyPlot.PlotModel { Title = "Hello, Forms!" };
			Model.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
			Content = new PlotView
			{
				Model = Model,
				VerticalOptions = LayoutOptions.Fill,
				HorizontalOptions = LayoutOptions.Fill,
			};
		}
	}
}
