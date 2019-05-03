using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RandomPage2 : ContentPage
	{
	    public RandomPage2()
	    {
	        InitializeComponent();
	        RandomPageBakcgroud.GestureRecognizers.Add(new TapGestureRecognizer
	        {
	            Command = new Command(() => GenrateRandColor()),
	        });
	    }

	    public void GenrateRandColor()
	    {
	        var Rand = new Random();
	        int min = 0;
	        int max = 255;

	        int randomR = Rand.Next(min, max);
	        int randomG = Rand.Next(min, max);
	        int randomB = Rand.Next(min, max);
	        RandomPageBakcgroud.BackgroundColor = Color.FromRgb(randomR, randomG, randomB);

	        string hex = randomR.ToString("X2") + randomG.ToString("X2") + randomB.ToString("X2");

	        ColorRLabel.Text = "R = " + randomR;
	        ColorGLabel.Text = "G = " + randomG;
	        ColorBLabel.Text = "B = " + randomB;
	        HexLabel.Text = "Hex = #" + hex;

	    }

	    protected override void OnAppearing()
	    {
	        GenrateRandColor();
	        //GoogleAnalytics.Current.Tracker.SendView("MainPage");
	    }
    }
}