using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Tracker
{
	public class TrackDataCache
	{
		private static TrackDataCache instance = new TrackDataCache();
		private ObservableCollection<Track> trackings = new ObservableCollection<Track>();

		private TrackDataCache() { }

		public static TrackDataCache Instance
		{
			get
			{
				return instance;
			}
		}

		public void addTrack(Track track) 
		{
			trackings.Add(track);
		}

		public ObservableCollection<Track> getTracks()
		{
			return trackings;
		}

	}
}
