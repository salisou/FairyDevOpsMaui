using FairyDevOpsMaui.Models;
using System.Collections.ObjectModel;

namespace FairyDevOpsMaui.ViewModels
{
    public class FairyViewModel
    {
        public ObservableCollection<FairyModel>? fairyModels = new()
        {
            new FairyModel
            {
                Name = "Promo progetto ",
                ReadTime = new TimeSpan(0, 30, 0),
                Image = ("work1.jpg")
            },
            new FairyModel
            {
                Name = "secondo progetto ",
                ReadTime = new TimeSpan(0, 30, 0),
                Image = ("work2.jpg")
            },
            new FairyModel
            {
                Name = "terzo progetto ",
                ReadTime = new TimeSpan(0, 30, 0),
                Image = ("work3.jpg")
            }
        };

        public ObservableCollection<FairyModel>? fairyModels2 = new()
        {
            new FairyModel
            {
                Name = "Promo progetto ",
                ReadTime = new TimeSpan(0, 30, 0),
                Image = ("work4.jpg")
            },
            new FairyModel
            {
                Name = "secondo progetto ",
                ReadTime = new TimeSpan(0, 30, 0),
                Image = ("work5.jpg")
            },
            new FairyModel
            {
                Name = "terzo progetto ",
                ReadTime = new TimeSpan(0, 30, 0),
                Image = ("work6.jpg")
            }
        };

        public static void GetFairy()
        {

        }

    }
}
