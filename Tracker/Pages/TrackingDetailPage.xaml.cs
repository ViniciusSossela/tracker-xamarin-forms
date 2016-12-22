using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tracker
{
	public partial class TrackingDetailPage : ContentPage
	{
		TrackingDetailViewModel viewModel = new TrackingDetailViewModel();

		public TrackingDetailPage(Track track)
		{
			InitializeComponent();
			viewModel.tracking = track;

		}
	}
}
