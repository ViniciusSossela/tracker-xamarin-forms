
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Tracker
{
	public partial class TrackerPage : ContentPage
	{

		HttpClient client;

		public TrackerPage()
		{
			Title = "Tracker";
			InitializeComponent();
			ExemploDeRequisicao();
			BindingContext = TrackDataCache.Instance.getTracks();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Console.WriteLine("QUERO CAFEEEE");

			NavigationPage newTrackingNavigation = new NavigationPage(new NewTrackingPage());
			Navigation.PushModalAsync(newTrackingNavigation);
		}

		private async void ExemploDeRequisicao()
		{
			client = new HttpClient();

			string codigo = "PN287778349BR";
			string url = $"https://evening-earth-59443.herokuapp.com/search/{codigo}";

			var uri = new Uri(string.Format(url, string.Empty));

			var response = await client.GetAsync(uri);
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				//TODO: Create the response object to be deserialized
				var a = JsonConvert.DeserializeObject<Object>(content);
			}
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{

			Track track = sender as Track;
			NavigationPage newTrackingNavigation = new NavigationPage(new TrackingDetailPage(track));
			Navigation.PushAsync(newTrackingNavigation);
		}
	}
}
