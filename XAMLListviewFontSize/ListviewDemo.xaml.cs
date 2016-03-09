using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;



namespace XAMLListviewFontSize
{
	public partial class ListviewDemo : ContentPage
	{

		private ObservableCollection<veggieModel> veggies { get; set; }

		public ListviewDemo ()
		{
			veggies = new ObservableCollection<veggieModel> ();

			InitializeComponent ();

			listViewCustom.ItemsSource = veggies;

			//Note that veggies is an observable collection, so the ListView will update in real time as items are added
			veggies.Add (new veggieModel () {
				name = "tomato",
				comment = "actually a fruit",
			});
			veggies.Add (new veggieModel () {
				name = "pizza",
				comment = "no comment",
			});
			veggies.Add (new veggieModel () {
				name = "romaine lettuce",
				comment = "good in salads",
			});
			veggies.Add (new veggieModel () {
				name = "zucchini",
				comment = "grows relatively easily",
			});

		}
	}
}


namespace XAMLListviewFontSize
{
	public class veggieModel
	{
		public string name { get; set; }

		public string comment { get; set; }

		public veggieModel ()
		{
		}
	}
}


