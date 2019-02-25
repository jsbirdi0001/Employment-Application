using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Employment_Application
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView cresult;
        EditText cname, cexperience;
        RadioButton cmarried, csingle, cmaster, cbachelor, cdiploma;
        CheckBox cenglish, cfrench, cspanish;
        Button ccalculate, creset;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
             
            cname = (EditText)FindViewById(Resource.Id.name);
            cexperience = (EditText)FindViewById(Resource.Id.experience);
            cmarried = (RadioButton)FindViewById(Resource.Id.married);
            csingle = (RadioButton)FindViewById(Resource.Id.single);
            cmaster = (RadioButton)FindViewById(Resource.Id.master);
            cbachelor = (RadioButton)FindViewById(Resource.Id.bachelor);
            cdiploma = (RadioButton)FindViewById(Resource.Id.diploma);
            cenglish = (CheckBox)FindViewById(Resource.Id.english);
            cfrench = (CheckBox)FindViewById(Resource.Id.french);
            cspanish = (CheckBox)FindViewById(Resource.Id.spanish);
            ccalculate = (Button)FindViewById(Resource.Id.calculate);
            creset = (Button)FindViewById(Resource.Id.reset);
            cresult = (TextView)FindViewById(Resource.Id.result);

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

