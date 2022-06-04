using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;

namespace ПолеЧудес
{
    public partial class MainPage : ContentPage
    {
        private double rot;
        Random r = new Random();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            rot = r.Next(0,360);
            await image.RotateTo(355 - CurrentKey, 5000);
            image.Rotation = 355 - CurrentKey;
            await DisplayAlert("Выигрыш", "Сумма: " + CurrentPoints, "OK");
        }
        public IEnumerable<KeyValuePair<double, string>> AnglePointsPairs { get; } = new Dictionary<double, string>()
        {
            {0, "350" },
            {4.5, "600" },
            {13.5, "+" },
            {22.5, "400" },
            {31.5, "700" },
            {40.5, "600" },
            {49.5, "x2" },
            {58.5, "600" },
            {67.5, "500" },
            {76.5, "400" },
            {85.5, "650" },
            {94.5, "450" },
            {103.5, "0" },
            {112.5, "1000" },
            {121.5, "500" },
            {130.5, "350" },
            {139.5, "550" },
            {148.5, "750" },
            {157.5, "600" },
            {166.5, "500" },
            {175.5, "350" },
            {184.5, "400" },
            {193.5, "x2" },
            {202.5, "600" },
            {211.5, "500" },
            {220.5, "n" },
            {229.5, "600" },
            {238.5, "350" },
            {247.5, "300" },
            {256.5, "200" },
            {265.5, "500" },
            {274.5, "600" },
            {283.5, "400" },
            {292.5, "m" },
            {301.5, "500" },
            {310.5, "350" },
            {319.5, "600" },
            {328.5, "400" },
            {337.5, "450" },
            {346.5, "500" },
            {355.5, "350" },

        }
        .OrderBy(item => item.Key);

        public double CurrentKey => AnglePointsPairs.Last(item => item.Key <= rot).Key;
        public string CurrentPoints => AnglePointsPairs.Last(item => item.Key <= rot).Value;
    }
}

