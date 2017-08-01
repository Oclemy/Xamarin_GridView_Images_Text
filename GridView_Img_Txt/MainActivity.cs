using Android.App;
using Android.Widget;
using Android.OS;
using Android.Runtime;

namespace GridView_Img_Txt
{
    [Activity(Label = "GridView_Img_Txt", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {//DECLARATIONS
        private GridView gv;
        private CustomAdapter adapter;
        private JavaList<Spacecraft> spacecrafts;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            gv = FindViewById<GridView>(Resource.Id.lv);


            //BIND ADAPTER
            adapter = new CustomAdapter(this, GetSpacecrafts());

            gv.Adapter = adapter;

            gv.ItemClick += gv_ItemClick;


        }

        /*
         * GRIDVIEW ITEM CLICK
         */
        void gv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, spacecrafts[e.Position].Name, ToastLength.Short).Show();
        }

        /*
         * DATA SOURCE 
         */
        private JavaList<Spacecraft> GetSpacecrafts()
        {
            spacecrafts = new JavaList<Spacecraft>();

            Spacecraft s;

            s = new Spacecraft("Enterprise", Resource.Drawable.enterprise);
            spacecrafts.Add(s);

            s = new Spacecraft("Hubble", Resource.Drawable.hubble);
            spacecrafts.Add(s);

            s = new Spacecraft("Kepler", Resource.Drawable.kepler);
            spacecrafts.Add(s);

            s = new Spacecraft("Spitzer", Resource.Drawable.spitzer);
            spacecrafts.Add(s);

            s = new Spacecraft("Rosetter", Resource.Drawable.rosetta);
            spacecrafts.Add(s);

            s = new Spacecraft("Voyager", Resource.Drawable.voyager);
            spacecrafts.Add(s);

            s = new Spacecraft("Opportunity", Resource.Drawable.opportunity);
            spacecrafts.Add(s);

            s = new Spacecraft("Pioneer", Resource.Drawable.pioneer);
            spacecrafts.Add(s);

            s = new Spacecraft("Challenger", Resource.Drawable.challenger);
            spacecrafts.Add(s);

            s = new Spacecraft("WMAP", Resource.Drawable.wmap);
            spacecrafts.Add(s);

            s = new Spacecraft("Columbia", Resource.Drawable.columbia);
            spacecrafts.Add(s);

            s = new Spacecraft("Casini", Resource.Drawable.pioneer);
            spacecrafts.Add(s);


            return spacecrafts;

        }
    }
}
