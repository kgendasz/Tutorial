using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Tutorial
{
    [Activity(Label = "Tutorial", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private List<Person> oList = new List<Person>();
        private ListView mListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
            mListView = FindViewById<ListView>(Resource.Id.MyListView);

            oList.Add(new Person {FirstName = "Joe", LastName = "Smith", Age = "22" , Gender = "male"} );
            oList.Add(new Person { FirstName = "Joe2", LastName = "Smith2", Age = "23", Gender = "male2" });
            oList.Add(new Person { FirstName = "Joe3", LastName = "Smith3", Age = "24", Gender = "male3" });

            MyListViewAdapter adapter = new MyListViewAdapter(this, oList);

            mListView.Adapter = adapter;
         
        }
    }
}

