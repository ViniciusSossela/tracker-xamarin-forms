using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Tracker
{
	public class TrackerPageViewModel
	{

		public ObservableCollection<Track> trackings
		{
			get;
			set;
		}

		public TrackerPageViewModel(ObservableCollection<Track> tracks)
		{
			trackings = tracks;
		}
	}
}
