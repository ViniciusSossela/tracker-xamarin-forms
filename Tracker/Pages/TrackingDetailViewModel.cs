using System;
using System.Collections.ObjectModel;

namespace Tracker
{
	public class TrackingDetailViewModel
	{
		public Track tracking
		{
			get;
			set;
		}

		public ObservableCollection<TrackingEvent> events
		{
			get;
			set;
		}

		public TrackingDetailViewModel()
		{
			
		}
	}
}
