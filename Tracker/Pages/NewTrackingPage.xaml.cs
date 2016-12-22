using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tracker
{
	public partial class NewTrackingPage : ContentPage
	{
		public Track track = new Track();
		public NewTrackingPage()
		{
			InitializeComponent();
			BindingContext = track;
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{

			TrackDataCache.Instance.addTrack(track);
			Navigation.PopModalAsync();
		}
	}
}
