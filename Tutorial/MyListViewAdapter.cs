using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Tutorial
{
    class MyListViewAdapter : BaseAdapter<Person>
    {
        private List<Person> mItems;
        private Context mContext;

        public MyListViewAdapter(Context context, List<Person> items)
        {
            mItems = items;
            mContext = context;
        }

        public override Person this[int position]
        {
            get { return mItems[position]; }

        }

        public override int Count
        {            
            get { return mItems.Count;}
        }


        public override long GetItemId(int position)
        {      
            return position; 
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                 row = LayoutInflater.From(mContext).Inflate(Resource.Layout.listview_row, null, false);

            }

            TextView txtFirstName = row.FindViewById<TextView>(Resource.Id.txtFirstName);
            TextView txtLastName = row.FindViewById<TextView>(Resource.Id.txtLastName);
            TextView txtAge = row.FindViewById<TextView>(Resource.Id.txtAge);
            TextView txtGender = row.FindViewById<TextView>(Resource.Id.txtGender);

            txtFirstName.Text = mItems[position].FirstName;
            txtLastName.Text = mItems[position].LastName;
            txtAge.Text = mItems[position].Age;
            txtGender.Text = mItems[position].Gender;

            return row;
           
        }
    }
}