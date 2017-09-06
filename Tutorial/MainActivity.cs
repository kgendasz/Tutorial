using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Tutorial
{
    [Activity(Label = "Tutorial", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private List<string> oList = new List<string>();
        private ListView mListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
            mListView = FindViewById<ListView>(Resource.Id.MyListView);
            oList.Add("Bob");
            oList.Add("Tom");
            oList.Add("Jim");

            MyListViewAdapter adapter = new MyListViewAdapter(this, oList);

            mListView.Adapter = adapter;
            mListView.Adapter = adapter;
        }
    }
}

