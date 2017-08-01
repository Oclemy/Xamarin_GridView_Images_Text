using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Object = Java.Lang.Object;

namespace GridView_Img_Txt
{
    class CustomAdapter : BaseAdapter
    {
        private readonly Context c;
        private readonly JavaList<Spacecraft> spacecrafts;
        private LayoutInflater inflater;

        /*
         * CONSTRUCTOR
         */
        public CustomAdapter(Context c, JavaList<Spacecraft> spacecrafts)
        {
            this.c = c;
            this.spacecrafts = spacecrafts;
        }

        /*
         * RETURN SPACECRAFT
         */
        public override Object GetItem(int position)
        {
            return spacecrafts.Get(position);
        }

        /*
         * SPACECRAFT ID
         */
        public override long GetItemId(int position)
        {
            return position;
        }

        /*
         * RETURN INFLATED VIEW
         */
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            //INITIALIZE INFLATER
            if (inflater == null)
            {
                inflater = (LayoutInflater)c.GetSystemService(Context.LayoutInflaterService);
            }

            //INFLATE OUR MODEL LAYOUT
            if (convertView == null)
            {
                convertView = inflater.Inflate(Resource.Layout.Model, parent, false);
            }

            //BIND DATA
            CustomAdapterViewHolder holder = new CustomAdapterViewHolder(convertView)
            {
                NameTxt = { Text = spacecrafts[position].Name }
            };
            holder.Img.SetImageResource(spacecrafts[position].Image);

            //convertView.SetBackgroundColor(Color.LightBlue);

            return convertView;
        }

        /*
         * TOTAL NUM OF SPACECRAFTS
         */
        public override int Count
        {
            get { return spacecrafts.Size(); }
        }
    }

    class CustomAdapterViewHolder : Java.Lang.Object
    {
        //adapter views to re-use
        public TextView NameTxt;
        public ImageView Img;

        public CustomAdapterViewHolder(View itemView)
        {
            NameTxt = itemView.FindViewById<TextView>(Resource.Id.nameTxt);
            Img = itemView.FindViewById<ImageView>(Resource.Id.spacecraftImg);

        }
    }
}