using FairyDevOpsMaui.Models;
using Microsoft.Maui.Handlers;
using System.Collections.ObjectModel;

namespace FairyDevOpsMaui
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<FairyModel>? FairyModels { get; set; }
        public ObservableCollection<FairyModel>? FairyModels2 { get; set; }

        public MainPage()
        {
            InitializeComponent();
            LoadData();
            BindingContext = this;

        }

        private void LoadData()
        {
            FairyModels = new ObservableCollection<FairyModel>
            {
                new FairyModel{Name = "Progetto 1", ReadTime = new TimeSpan (0, 30, 0), Image = "work1.jpg"},
                new FairyModel{Name = "Progetto 2", ReadTime = new TimeSpan (0, 25, 0), Image = "work2.jpg"},
                new FairyModel{Name = "Progetto 3", ReadTime = new TimeSpan (0, 20, 0), Image = "work3.jpg"},
            };

            FairyModels2 = new ObservableCollection<FairyModel>
            {
                new FairyModel{Name = "Progetto 4", ReadTime = new TimeSpan (0, 25, 0), Image = "work4.jpg"},
                new FairyModel{Name = "Progetto 5", ReadTime = new TimeSpan (0, 25, 0), Image = "work5.jpg"},
                new FairyModel{Name = "Progetto 6", ReadTime = new TimeSpan (0, 30, 0), Image = "work6.jpg"},
            };
        }

        private void ModificaRicerca()
        {
#if ANDROID
            SearchBarHandler.Mapper.AppendToMapping("CustomSearchIconColor", (handler, view) =>
            {
                var context = handler.PlatformView.Context;
                var searchIconId = context.Resources.GetIdentifier("search_mag_icon", "id", context.PackageName);
                if (searchIconId != 0)
                {
                    var searchIcon = handler.PlatformView.FindViewById<Android.Widget.ImageView>(searchIconId);
                    searchIcon.SetColorFilter(Android.Graphics.Color.Rgb(172, 157, 185), Android.Graphics.PorterDuff.Mode.SrcIn);
                }
            });
        }
#endif
    }

}
