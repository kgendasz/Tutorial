using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System;

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
            mListView.ItemClick += MListView_ItemClick;
            mListView.ItemLongClick += MListView_ItemLongClick;

            mListView.ItemClick += ItemClick2;
        }

        private void ItemClick2(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine("Second Method");
        }

        private void MListView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            Console.WriteLine(oList[e.Position].LastName);
        }

        

        private void MListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine(oList[e.Position].FirstName);
        }

        private void MListView_Click(object sender, System.EventArgs e)
        {
           ;
        }
    }
}

