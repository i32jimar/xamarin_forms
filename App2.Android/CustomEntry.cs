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
using App2.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

//para hacer extensible la propiedad a todos los Entry en Android
[assembly: ExportRenderer(typeof(Entry),typeof(CustomEntry))]
namespace App2.Droid
{
    public class CustomEntry : EntryRenderer
    {
        
        //pasamos el parametro context a la clase base
        public CustomEntry(Context context) : base(context)
        {

        }

        
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control ==null || e.NewElement ==null)
            {
                return;
            }
            Control.Background = null;
            if (!e.NewElement.IsPassword )
            {
                Control.InputType = Android.Text.InputTypes.TextFlagNoSuggestions; 
            }
        }
    }
}